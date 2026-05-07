namespace pryAcademiaDeMúsicaRomero
{
    partial class frmNuevoCantante
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
            this.lblNúmero = new System.Windows.Forms.Label();
            this.cmbNúmero = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNúmero
            // 
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmero.ForeColor = System.Drawing.Color.Black;
            this.lblNúmero.Location = new System.Drawing.Point(33, 23);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(65, 22);
            this.lblNúmero.TabIndex = 0;
            this.lblNúmero.Text = "Número";
            // 
            // cmbNúmero
            // 
            this.cmbNúmero.FormattingEnabled = true;
            this.cmbNúmero.Location = new System.Drawing.Point(12, 63);
            this.cmbNúmero.Name = "cmbNúmero";
            this.cmbNúmero.Size = new System.Drawing.Size(121, 21);
            this.cmbNúmero.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(196, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(165, 63);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(124, 21);
            this.cmbNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(110, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmNuevoCantante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 204);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbNúmero);
            this.Controls.Add(this.lblNúmero);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "frmNuevoCantante";
            this.Text = "Nuevo Cantante";
            this.Load += new System.EventHandler(this.frmNuevoCantante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.ComboBox cmbNúmero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}