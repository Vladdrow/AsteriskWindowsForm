namespace WindowsFormsAppASTERISK {
    partial class menu {
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelNameUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVerUsuarios = new System.Windows.Forms.Button();
            this.buttonHistorialLlamadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRegistrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrar.Location = new System.Drawing.Point(30, 108);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(333, 63);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Registrar Usuario";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(30, 177);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(333, 63);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Actualizar Datos Usuario";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelNameUsuario
            // 
            this.labelNameUsuario.AutoSize = true;
            this.labelNameUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUsuario.Location = new System.Drawing.Point(37, 25);
            this.labelNameUsuario.Name = "labelNameUsuario";
            this.labelNameUsuario.Size = new System.Drawing.Size(117, 30);
            this.labelNameUsuario.TabIndex = 3;
            this.labelNameUsuario.Text = "(USUARIO)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonVerUsuarios
            // 
            this.buttonVerUsuarios.BackColor = System.Drawing.Color.Firebrick;
            this.buttonVerUsuarios.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerUsuarios.ForeColor = System.Drawing.Color.White;
            this.buttonVerUsuarios.Location = new System.Drawing.Point(30, 246);
            this.buttonVerUsuarios.Name = "buttonVerUsuarios";
            this.buttonVerUsuarios.Size = new System.Drawing.Size(333, 63);
            this.buttonVerUsuarios.TabIndex = 5;
            this.buttonVerUsuarios.Text = "Listar Usuarios";
            this.buttonVerUsuarios.UseVisualStyleBackColor = false;
            this.buttonVerUsuarios.Click += new System.EventHandler(this.buttonVerUsuarios_Click);
            // 
            // buttonHistorialLlamadas
            // 
            this.buttonHistorialLlamadas.BackColor = System.Drawing.Color.Firebrick;
            this.buttonHistorialLlamadas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHistorialLlamadas.Enabled = false;
            this.buttonHistorialLlamadas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistorialLlamadas.ForeColor = System.Drawing.Color.White;
            this.buttonHistorialLlamadas.Location = new System.Drawing.Point(30, 315);
            this.buttonHistorialLlamadas.Name = "buttonHistorialLlamadas";
            this.buttonHistorialLlamadas.Size = new System.Drawing.Size(333, 63);
            this.buttonHistorialLlamadas.TabIndex = 6;
            this.buttonHistorialLlamadas.Text = "Historial de llamadas";
            this.buttonHistorialLlamadas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Korpy Corp.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNameUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrador";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHistorialLlamadas);
            this.Controls.Add(this.buttonVerUsuarios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Label labelNameUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVerUsuarios;
        private System.Windows.Forms.Button buttonHistorialLlamadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}