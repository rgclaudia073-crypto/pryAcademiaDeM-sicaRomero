namespace pryAcademiaDeMúsicaRomero
{
    partial class fmrAcademiaMúsica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mst = new System.Windows.Forms.MenuStrip();
            this.cantantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevosTemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVideoTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst
            // 
            this.mst.BackColor = System.Drawing.Color.RosyBrown;
            this.mst.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantantesToolStripMenuItem,
            this.temasToolStripMenuItem});
            this.mst.Location = new System.Drawing.Point(0, 0);
            this.mst.Name = "mst";
            this.mst.Size = new System.Drawing.Size(395, 24);
            this.mst.TabIndex = 0;
            this.mst.Text = "menuStrip1";
            // 
            // cantantesToolStripMenuItem
            // 
            this.cantantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCantToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cantantesToolStripMenuItem.Name = "cantantesToolStripMenuItem";
            this.cantantesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cantantesToolStripMenuItem.Text = "Cantante";
            // 
            // nuevoCantToolStripMenuItem
            // 
            this.nuevoCantToolStripMenuItem.Name = "nuevoCantToolStripMenuItem";
            this.nuevoCantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoCantToolStripMenuItem.Text = "Nuevo Cantante...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir...";
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosTemasToolStripMenuItem,
            this.verVideoTemaToolStripMenuItem});
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.temasToolStripMenuItem.Text = "Temas";
            // 
            // nuevosTemasToolStripMenuItem
            // 
            this.nuevosTemasToolStripMenuItem.Name = "nuevosTemasToolStripMenuItem";
            this.nuevosTemasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevosTemasToolStripMenuItem.Text = "Nuevos temas";
            // 
            // verVideoTemaToolStripMenuItem
            // 
            this.verVideoTemaToolStripMenuItem.Name = "verVideoTemaToolStripMenuItem";
            this.verVideoTemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verVideoTemaToolStripMenuItem.Text = "Ver Video Tema";
            // 
            // fmrAcademiaMúsica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 268);
            this.Controls.Add(this.mst);
            this.MainMenuStrip = this.mst;
            this.Name = "fmrAcademiaMúsica";
            this.Text = "Academia De Música";
            this.mst.ResumeLayout(false);
            this.mst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst;
        private System.Windows.Forms.ToolStripMenuItem cantantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevosTemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVideoTemaToolStripMenuItem;
    }
}

