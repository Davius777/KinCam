using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Configuration;

namespace KinCam {
    //TODO: Partir de la fecha inicio hasta la fecha fin.
    public partial class Wfrm_Main : Form { 
        bool _Stream;
        VideoCapture _capture;
        // Variables usadas en la detección de movimiento.
        Image<Bgr, byte> diffFrame, lFrame;
        bool fFrame = false;
        SmtpClient client;
        MailMessage msg;
        string path;
        public Wfrm_Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            int n;
            try {
                string mail = ConfigurationManager.AppSettings["mail"];
                path = ConfigurationManager.AppSettings["path"];
                Int32.TryParse(ConfigurationManager.AppSettings["camara"], out n);
                // Inicialización de cámara.
                _Stream = false;
                _capture = new VideoCapture(n, VideoCapture.API.Any);
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 240);
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 320);
                InitMail(mail);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCaptura_Click(object sender, EventArgs e) {
            imgSalida.Image = imgStream.Image;
        }

        private void BtnStream_Click(object sender, EventArgs e) {
            if (!_Stream) {
                // Inicio de transmisión.
                Application.Idle += transmitiendo;
                btnStream.Text = "Detener video";
            }
            else {
                // Fin de transmisión.
                Application.Idle -= transmitiendo;
                btnStream.Text = "Iniciar video";
            }
            _Stream = !_Stream;
        }
        private void transmitiendo (object sender, EventArgs e) {
            string pic;
            int sensibilidad;
            try {
                if (_capture.IsOpened) {
                    var frameActual = _capture.QueryFrame().ToImage<Emgu.CV.Structure.Bgr, byte>();
                    System.Int32.TryParse(txtSense.Text, out sensibilidad);
                    if (fFrame) {
                        diffFrame = frameActual.AbsDiff(lFrame)
                            .ThresholdBinary(new Bgr(20,20,20), new Bgr(255,255,255))
                            .Erode(2)
                            .Dilate(2);
                        int movimientos = diffFrame.CountNonzero()[0];
                        lblSense.Text = movimientos.ToString();
                        if (movimientos > sensibilidad) {
                            pic = string.Concat(path, DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString(), ".jpg");
                            GuardaImagen(pic);
                        }
                    }
                    var bmp = frameActual.Bitmap;
                    imgStream.Image = bmp;
                    lFrame = frameActual.Clone();
                    fFrame = true;
                }
                else {
                    MessageBox.Show("No ha sido posible obtener la camara seleccionada, configurela correctamente.");
                    this.Close();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void BtnGuarda_Click(object sender, EventArgs e) {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = @"Guarda tu imagen :)";
            if(saveDlg.ShowDialog() == DialogResult.OK) {
                imgSalida.Image.Save(saveDlg.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("La imagen ha sido guardada.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            _capture.Dispose();
        }

        private void RIni_TextChanged(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            string patron = "\\d{1,2}:\\d{2}\\s*(AM|PM)";
            string[] t1 = new string[2];
            string[] t2 = new string[2];
            // Validación de patrón.
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt.Text, patron, System.Text.RegularExpressions.RegexOptions.CultureInvariant)) {
                MessageBox.Show("No es una formato de hora valido. ('hh:mm AM|PM') ");
                txt.Text = "00:00";
                return;
            }
            t1 = txt.Text.Split(' ')[0].Split(':');
            t2 = tFin.Text.Split(' ')[0].Split(':');
            DateTime d1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int16.Parse(t1[0]), Int16.Parse(t1[1]), 0);
            DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int16.Parse(t2[0]), Int16.Parse(t2[1]), 0);
            if (d1 > d2) {
                MessageBox.Show("La hora de inicio no puede ser mayor que la hora final.");
                tFin.Text = txt.Text;
                return;
            }
        }

        private void RFin_TextChanged(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            string patron = "\\d{1,2}:\\d{2}\\s*(AM|PM)";
            string[] t1 = new string[2];
            string[] t2 = new string[2];
            // Validación de patrón.
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt.Text, patron, System.Text.RegularExpressions.RegexOptions.CultureInvariant)) {
                MessageBox.Show("No es una formato de hora valido. ('hh:mm AM|PM') ");
                txt.Text = "00:00";
                return;
            }
            t1 = txt.Text.Split(' ')[0].Split(':');
            t2 = tIni.Text.Split(' ')[0].Split(':');
            DateTime d1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int16.Parse(t1[0]), Int16.Parse(t1[1]), 0);
            DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int16.Parse(t2[0]), Int16.Parse(t2[1]), 0);
            if (d1 < d2) {
                MessageBox.Show("La hora final no puede ser menor que la hora inicial.");
                tIni.Text = txt.Text;
                return;
            }
        }

        private void GuardaImagen(string pic) {
            string[] t1 = tIni.Text.Split(' ')[0].Split(':');
            string[] t2 = tFin.Text.Split(' ')[0].Split(':');
            DateTime d1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int16.Parse(t1[0]), Int16.Parse(t1[1]), 0);
            DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int16.Parse(t2[0]), Int16.Parse(t2[1]), 0);
            bool inRange = (DateTime.Now >= d1 && DateTime.Now >= d2);
            if (chkTime.Checked  && !inRange) {
                return;
            }
            if (!File.Exists(pic)) {
                lblMovs.Text = string.Concat("Movimiento detectado: ", DateTime.Now);
                msg.Body = lblMovs.Text;
                imgStream.Image.Save(pic);
                msg.Attachments.Add(new Attachment(pic));
            }
            if (chkCorreo.Checked)
                client.Send(msg);
        }

        private void InitMail(string mail) {
            msg = new MailMessage();
            msg.Subject = "DMotion";
            msg.Body = "Movimiento detectado";
            msg.To.Add(mail);
            msg.From = new MailAddress(mail, "4r10k");

            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(mail, "qweRTY1234");
        }
    }
}
