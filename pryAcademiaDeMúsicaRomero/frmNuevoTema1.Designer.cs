namespace pryAcademiaDeMúsicaRomero
{
    partial class frmNuevoTema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNúmeroTema = new System.Windows.Forms.Label();
            this.lblNombreTema = new System.Windows.Forms.Label();
            this.lblCantante = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lblNúmeroTema
            // 
            this.lblNúmeroTema.AutoSize = true;
            this.lblNúmeroTema.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmeroTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNúmeroTema.Location = new System.Drawing.Point(2, 31);
            this.lblNúmeroTema.Name = "lblNúmeroTema";
            this.lblNúmeroTema.Size = new System.Drawing.Size(125, 22);
            this.lblNúmeroTema.TabIndex = 0;
            this.lblNúmeroTema.Text = "Número de Tema";
            // 
            // lblNombreTema
            // 
            this.lblNombreTema.AutoSize = true;
            this.lblNombreTema.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreTema.Location = new System.Drawing.Point(2, 73);
            this.lblNombreTema.Name = "lblNombreTema";
            this.lblNombreTema.Size = new System.Drawing.Size(124, 22);
            this.lblNombreTema.TabIndex = 1;
            this.lblNombreTema.Text = "Nombre de Tema";
            // 
            // lblCantante
            // 
            this.lblCantante.AutoSize = true;
            this.lblCantante.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantante.Location = new System.Drawing.Point(2, 149);
            this.lblCantante.Name = "lblCantante";
            this.lblCantante.Size = new System.Drawing.Size(73, 22);
            this.lblCantante.TabIndex = 2;
            this.lblCantante.Text = "Cantante";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(2, 112);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(90, 22);
            this.lblVideo.TabIndex = 5;
            this.lblVideo.Text = "URL Video";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(144, 111);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(278, 24);
            this.webBrowser1.TabIndex = 6;
            // 
            // frmNuevoTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 315);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCantante);
            this.Controls.Add(this.lblNombreTema);
            this.Controls.Add(this.lblNúmeroTema);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmNuevoTema";
            this.Text = "Nuevo Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNúmeroTema;
        private System.Windows.Forms.Label lblNombreTema;
        private System.Windows.Forms.Label lblCantante;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}