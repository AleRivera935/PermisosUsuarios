namespace PermisosBD
{
    partial class Menu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ModuloRefacciones = new System.Windows.Forms.ToolStripButton();
            this.ModuloTaller = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModuloRefacciones,
            this.ModuloTaller,
            this.btnSalir,
            this.btnUsuarios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(211, 554);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ModuloRefacciones
            // 
            this.ModuloRefacciones.AutoSize = false;
            this.ModuloRefacciones.BackgroundImage = global::PermisosBD.Properties.Resources.ModuloRefacciones1;
            this.ModuloRefacciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModuloRefacciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModuloRefacciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModuloRefacciones.Name = "ModuloRefacciones";
            this.ModuloRefacciones.Size = new System.Drawing.Size(210, 120);
            this.ModuloRefacciones.Text = "ModuloRefacciones";
            this.ModuloRefacciones.Click += new System.EventHandler(this.ModuloRefacciones_Click);
            // 
            // ModuloTaller
            // 
            this.ModuloTaller.AutoSize = false;
            this.ModuloTaller.BackgroundImage = global::PermisosBD.Properties.Resources.ModuloTaller1;
            this.ModuloTaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModuloTaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModuloTaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModuloTaller.Name = "ModuloTaller";
            this.ModuloTaller.Size = new System.Drawing.Size(210, 120);
            this.ModuloTaller.Text = "MuduloTaller";
            this.ModuloTaller.Click += new System.EventHandler(this.ModuloTaller_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.BackgroundImage = global::PermisosBD.Properties.Resources.SalirMenu1;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 120);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.BackgroundImage = global::PermisosBD.Properties.Resources.Usuarios;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(210, 120);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PermisosBD.Properties.Resources.MENU1__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 554);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ModuloRefacciones;
        private System.Windows.Forms.ToolStripButton ModuloTaller;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
    }
}