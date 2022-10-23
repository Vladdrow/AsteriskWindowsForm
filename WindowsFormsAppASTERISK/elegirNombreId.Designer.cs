namespace WindowsFormsAppASTERISK {
    partial class elegirNombreId {
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
            this.buttonNombre1 = new System.Windows.Forms.Button();
            this.buttonNombre2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNombre1
            // 
            this.buttonNombre1.BackColor = System.Drawing.Color.Firebrick;
            this.buttonNombre1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNombre1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNombre1.ForeColor = System.Drawing.Color.White;
            this.buttonNombre1.Location = new System.Drawing.Point(26, 37);
            this.buttonNombre1.Name = "buttonNombre1";
            this.buttonNombre1.Size = new System.Drawing.Size(208, 55);
            this.buttonNombre1.TabIndex = 0;
            this.buttonNombre1.Text = "(Nombre 1)";
            this.buttonNombre1.UseVisualStyleBackColor = false;
            this.buttonNombre1.Click += new System.EventHandler(this.buttonNombre1_Click);
            // 
            // buttonNombre2
            // 
            this.buttonNombre2.BackColor = System.Drawing.Color.Firebrick;
            this.buttonNombre2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNombre2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNombre2.ForeColor = System.Drawing.Color.White;
            this.buttonNombre2.Location = new System.Drawing.Point(278, 37);
            this.buttonNombre2.Name = "buttonNombre2";
            this.buttonNombre2.Size = new System.Drawing.Size(208, 55);
            this.buttonNombre2.TabIndex = 1;
            this.buttonNombre2.Text = "(Nombre 2)";
            this.buttonNombre2.UseVisualStyleBackColor = false;
            this.buttonNombre2.Click += new System.EventHandler(this.buttonNombre2_Click);
            // 
            // elegirNombreId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(532, 143);
            this.Controls.Add(this.buttonNombre2);
            this.Controls.Add(this.buttonNombre1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "elegirNombreId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir nombre de Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonNombre1;
        public System.Windows.Forms.Button buttonNombre2;
    }
}