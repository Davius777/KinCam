namespace KinCam {
    partial class Wfrm_Main {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.imgSalida = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.imgStream = new System.Windows.Forms.PictureBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSense = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMovs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tFin = new System.Windows.Forms.TextBox();
            this.tIni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkCorreo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStream)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgSalida
            // 
            this.imgSalida.Location = new System.Drawing.Point(554, 9);
            this.imgSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgSalida.Name = "imgSalida";
            this.imgSalida.Size = new System.Drawing.Size(480, 369);
            this.imgSalida.TabIndex = 0;
            this.imgSalida.TabStop = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(686, 388);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(112, 35);
            this.btnCaptura.TabIndex = 1;
            this.btnCaptura.Text = "Capturar";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.BtnCaptura_Click);
            // 
            // imgStream
            // 
            this.imgStream.Location = new System.Drawing.Point(9, 9);
            this.imgStream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgStream.Name = "imgStream";
            this.imgStream.Size = new System.Drawing.Size(480, 369);
            this.imgStream.TabIndex = 0;
            this.imgStream.TabStop = false;
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(140, 388);
            this.btnStream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(168, 35);
            this.btnStream.TabIndex = 1;
            this.btnStream.Text = "Inicia video";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.BtnStream_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(807, 388);
            this.btnGuarda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(112, 35);
            this.btnGuarda.TabIndex = 2;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.BtnGuarda_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 669);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSense);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblMovs);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.imgStream);
            this.tabPage1.Controls.Add(this.btnGuarda);
            this.tabPage1.Controls.Add(this.btnStream);
            this.tabPage1.Controls.Add(this.btnCaptura);
            this.tabPage1.Controls.Add(this.imgSalida);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1046, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSense
            // 
            this.lblSense.AutoSize = true;
            this.lblSense.Location = new System.Drawing.Point(199, 474);
            this.lblSense.Name = "lblSense";
            this.lblSense.Size = new System.Drawing.Size(18, 20);
            this.lblSense.TabIndex = 6;
            this.lblSense.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sensibilidad:";
            // 
            // lblMovs
            // 
            this.lblMovs.AutoSize = true;
            this.lblMovs.Location = new System.Drawing.Point(199, 441);
            this.lblMovs.Name = "lblMovs";
            this.lblMovs.Size = new System.Drawing.Size(18, 20);
            this.lblMovs.TabIndex = 4;
            this.lblMovs.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movimientos detectados:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tFin);
            this.tabPage2.Controls.Add(this.tIni);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSense);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chkTime);
            this.tabPage2.Controls.Add(this.chkCorreo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1046, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajustes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "-";
            // 
            // tFin
            // 
            this.tFin.Location = new System.Drawing.Point(361, 114);
            this.tFin.Name = "tFin";
            this.tFin.Size = new System.Drawing.Size(100, 26);
            this.tFin.TabIndex = 6;
            this.tFin.Text = "0:00 AM";
            this.tFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tFin.Leave += new System.EventHandler(this.RFin_TextChanged);
            // 
            // tIni
            // 
            this.tIni.Location = new System.Drawing.Point(235, 114);
            this.tIni.Name = "tIni";
            this.tIni.Size = new System.Drawing.Size(100, 26);
            this.tIni.TabIndex = 5;
            this.tIni.Text = "0:00 AM";
            this.tIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tIni.Leave += new System.EventHandler(this.RIni_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rango de actividad:";
            // 
            // txtSense
            // 
            this.txtSense.Location = new System.Drawing.Point(196, 66);
            this.txtSense.Name = "txtSense";
            this.txtSense.Size = new System.Drawing.Size(100, 26);
            this.txtSense.TabIndex = 3;
            this.txtSense.Text = "55000";
            this.txtSense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sensibilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activar envio de correo: ";
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(196, 116);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(22, 21);
            this.chkTime.TabIndex = 0;
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // chkCorreo
            // 
            this.chkCorreo.AutoSize = true;
            this.chkCorreo.Location = new System.Drawing.Point(196, 30);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(22, 21);
            this.chkCorreo.TabIndex = 0;
            this.chkCorreo.UseVisualStyleBackColor = true;
            // 
            // Wfrm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 697);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Wfrm_Main";
            this.Text = "Control de movimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStream)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSalida;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.PictureBox imgStream;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCorreo;
        private System.Windows.Forms.TextBox txtSense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tFin;
        private System.Windows.Forms.TextBox tIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTime;
    }
}

