namespace WindowsFormsAppASTERISK {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelclave = new System.Windows.Forms.Label();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.textBoxclave = new System.Windows.Forms.TextBox();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOcultar = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.Location = new System.Drawing.Point(3, 190);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(149, 32);
            this.labelusuario.TabIndex = 0;
            this.labelusuario.Text = "ID Usuario :";
            // 
            // labelclave
            // 
            this.labelclave.AutoSize = true;
            this.labelclave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclave.Location = new System.Drawing.Point(63, 242);
            this.labelclave.Name = "labelclave";
            this.labelclave.Size = new System.Drawing.Size(89, 32);
            this.labelclave.TabIndex = 1;
            this.labelclave.Text = "Clave :";
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdUsuario.Location = new System.Drawing.Point(158, 190);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(224, 35);
            this.textBoxIdUsuario.TabIndex = 2;
            // 
            // textBoxclave
            // 
            this.textBoxclave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxclave.Location = new System.Drawing.Point(158, 241);
            this.textBoxclave.Name = "textBoxclave";
            this.textBoxclave.PasswordChar = '*';
            this.textBoxclave.Size = new System.Drawing.Size(224, 35);
            this.textBoxclave.TabIndex = 3;
            // 
            // buttoningresar
            // 
            this.buttoningresar.BackColor = System.Drawing.Color.Firebrick;
            this.buttoningresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoningresar.ForeColor = System.Drawing.Color.White;
            this.buttoningresar.Location = new System.Drawing.Point(119, 309);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(238, 54);
            this.buttoningresar.TabIndex = 4;
            this.buttoningresar.Text = "Ingresar";
            this.buttoningresar.UseVisualStyleBackColor = false;
            this.buttoningresar.Click += new System.EventHandler(this.buttoningresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korpy Corp.";
            // 
            // buttonOcultar
            // 
            this.buttonOcultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOcultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOcultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOcultar.Location = new System.Drawing.Point(396, 241);
            this.buttonOcultar.Name = "buttonOcultar";
            this.buttonOcultar.Size = new System.Drawing.Size(70, 34);
            this.buttonOcultar.TabIndex = 8;
            this.buttonOcultar.Text = "Ocultar";
            this.buttonOcultar.UseVisualStyleBackColor = false;
            this.buttonOcultar.Click += new System.EventHandler(this.buttonOcultar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.BackColor = System.Drawing.Color.Firebrick;
            this.buttonVer.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVer.ForeColor = System.Drawing.Color.White;
            this.buttonVer.Location = new System.Drawing.Point(396, 241);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(70, 34);
            this.buttonVer.TabIndex = 9;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = false;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttoningresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(478, 410);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonOcultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNameUser);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.textBoxclave);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.labelclave);
            this.Controls.Add(this.labelusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelclave;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.TextBox textBoxclave;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOcultar;
        private System.Windows.Forms.Button buttonVer;
    }
}

