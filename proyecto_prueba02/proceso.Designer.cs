namespace proyecto_prueba02
{
    partial class proceso
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTareasToolStripMenuItem,
            this.gestionarHorariosToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "inicio";
            // 
            // verTareasToolStripMenuItem
            // 
            this.verTareasToolStripMenuItem.Name = "verTareasToolStripMenuItem";
            this.verTareasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verTareasToolStripMenuItem.Text = "Ver tareas";
            // 
            // gestionarHorariosToolStripMenuItem
            // 
            this.gestionarHorariosToolStripMenuItem.Name = "gestionarHorariosToolStripMenuItem";
            this.gestionarHorariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarHorariosToolStripMenuItem.Text = "Gestionar Horarios";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.usuarioExistenteToolStripMenuItem,
            this.horasExtrasToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.gestionToolStripMenuItem.Text = "gestion";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // usuarioExistenteToolStripMenuItem
            // 
            this.usuarioExistenteToolStripMenuItem.Name = "usuarioExistenteToolStripMenuItem";
            this.usuarioExistenteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.usuarioExistenteToolStripMenuItem.Text = "Usuario existente";
            // 
            // horasExtrasToolStripMenuItem
            // 
            this.horasExtrasToolStripMenuItem.Name = "horasExtrasToolStripMenuItem";
            this.horasExtrasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.horasExtrasToolStripMenuItem.Text = "Horas Extras";
            // 
            // proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "proceso";
            this.Text = "proceso";
            this.Load += new System.EventHandler(this.proceso_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarHorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioExistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasExtrasToolStripMenuItem;
    }
}