namespace WindowsFormsAppASTERISK {
    partial class mdiContainer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.todosLosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosNormalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosUsuariosToolStripMenuItem,
            this.usuariosAdminToolStripMenuItem,
            this.usuariosNormalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // todosLosUsuariosToolStripMenuItem
            // 
            this.todosLosUsuariosToolStripMenuItem.Name = "todosLosUsuariosToolStripMenuItem";
            this.todosLosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(157, 25);
            this.todosLosUsuariosToolStripMenuItem.Text = "Todos los Usuarios";
            this.todosLosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.todosLosUsuariosToolStripMenuItem_Click);
            // 
            // usuariosAdminToolStripMenuItem
            // 
            this.usuariosAdminToolStripMenuItem.Name = "usuariosAdminToolStripMenuItem";
            this.usuariosAdminToolStripMenuItem.Size = new System.Drawing.Size(209, 25);
            this.usuariosAdminToolStripMenuItem.Text = "Usuarios Administradores";
            this.usuariosAdminToolStripMenuItem.Click += new System.EventHandler(this.usuariosAdminToolStripMenuItem_Click);
            // 
            // usuariosNormalesToolStripMenuItem
            // 
            this.usuariosNormalesToolStripMenuItem.Name = "usuariosNormalesToolStripMenuItem";
            this.usuariosNormalesToolStripMenuItem.Size = new System.Drawing.Size(155, 25);
            this.usuariosNormalesToolStripMenuItem.Text = "Usuarios normales";
            this.usuariosNormalesToolStripMenuItem.Click += new System.EventHandler(this.usuariosNormalesToolStripMenuItem_Click);
            // 
            // mdiContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(999, 505);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mdiContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdiContainer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem todosLosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosNormalesToolStripMenuItem;
    }
}