namespace WindowsFormsAppASTERISK {
    partial class eliminarUsuario {
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
            this.labelEliminarUsuario = new System.Windows.Forms.Label();
            this.labelIdUsuario = new System.Windows.Forms.Label();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonOcultar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCambiarCargo = new System.Windows.Forms.Button();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.comboBoxCargos = new System.Windows.Forms.ComboBox();
            this.textBoxNombreID = new System.Windows.Forms.TextBox();
            this.labelNombreID = new System.Windows.Forms.Label();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEliminarUsuario
            // 
            this.labelEliminarUsuario.AutoSize = true;
            this.labelEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarUsuario.Location = new System.Drawing.Point(172, 23);
            this.labelEliminarUsuario.Name = "labelEliminarUsuario";
            this.labelEliminarUsuario.Size = new System.Drawing.Size(294, 30);
            this.labelEliminarUsuario.TabIndex = 2;
            this.labelEliminarUsuario.Text = "Actualizar  datos del Usuario";
            // 
            // labelIdUsuario
            // 
            this.labelIdUsuario.AutoSize = true;
            this.labelIdUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdUsuario.Location = new System.Drawing.Point(37, 72);
            this.labelIdUsuario.Name = "labelIdUsuario";
            this.labelIdUsuario.Size = new System.Drawing.Size(132, 30);
            this.labelIdUsuario.TabIndex = 3;
            this.labelIdUsuario.Text = "Id Usuario : ";
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdUsuario.Location = new System.Drawing.Point(177, 69);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(270, 35);
            this.textBoxIdUsuario.TabIndex = 4;
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Enabled = false;
            this.textBoxExtension.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExtension.Location = new System.Drawing.Point(177, 266);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(210, 35);
            this.textBoxExtension.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(177, 162);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(353, 35);
            this.textBoxNombre.TabIndex = 12;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtension.Location = new System.Drawing.Point(37, 269);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(121, 30);
            this.labelExtension.TabIndex = 16;
            this.labelExtension.Text = "Extension :";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(37, 165);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(106, 30);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.Location = new System.Drawing.Point(37, 375);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(83, 30);
            this.labelCargo.TabIndex = 19;
            this.labelCargo.Text = "Cargo :";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(421, 508);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(169, 52);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Salir";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAceptar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(33, 508);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(166, 52);
            this.buttonAceptar.TabIndex = 20;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(468, 61);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(131, 52);
            this.buttonBuscar.TabIndex = 22;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Enabled = false;
            this.textBoxClave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.Location = new System.Drawing.Point(177, 426);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(210, 35);
            this.textBoxClave.TabIndex = 23;
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenia.Location = new System.Drawing.Point(37, 429);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(77, 30);
            this.labelContrasenia.TabIndex = 24;
            this.labelContrasenia.Text = "Clave :";
            // 
            // buttonVer
            // 
            this.buttonVer.BackColor = System.Drawing.Color.Firebrick;
            this.buttonVer.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVer.ForeColor = System.Drawing.Color.White;
            this.buttonVer.Location = new System.Drawing.Point(396, 427);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(70, 34);
            this.buttonVer.TabIndex = 26;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = false;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonOcultar
            // 
            this.buttonOcultar.BackColor = System.Drawing.Color.Red;
            this.buttonOcultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOcultar.ForeColor = System.Drawing.Color.White;
            this.buttonOcultar.Location = new System.Drawing.Point(397, 427);
            this.buttonOcultar.Name = "buttonOcultar";
            this.buttonOcultar.Size = new System.Drawing.Size(70, 34);
            this.buttonOcultar.TabIndex = 25;
            this.buttonOcultar.Text = "Ocultar";
            this.buttonOcultar.UseVisualStyleBackColor = false;
            this.buttonOcultar.Click += new System.EventHandler(this.buttonOcultar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(214, 508);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(192, 52);
            this.buttonEliminar.TabIndex = 27;
            this.buttonEliminar.Text = "Eliminar Usuario";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCambiarCargo
            // 
            this.buttonCambiarCargo.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCambiarCargo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarCargo.ForeColor = System.Drawing.Color.White;
            this.buttonCambiarCargo.Location = new System.Drawing.Point(397, 378);
            this.buttonCambiarCargo.Name = "buttonCambiarCargo";
            this.buttonCambiarCargo.Size = new System.Drawing.Size(159, 34);
            this.buttonCambiarCargo.TabIndex = 28;
            this.buttonCambiarCargo.Text = "Hablilitar";
            this.buttonCambiarCargo.UseVisualStyleBackColor = false;
            this.buttonCambiarCargo.Click += new System.EventHandler(this.buttonCambiarCargo_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Enabled = false;
            this.textBoxApellido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(177, 213);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(353, 35);
            this.textBoxApellido.TabIndex = 29;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(37, 216);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(108, 30);
            this.labelApellido.TabIndex = 30;
            this.labelApellido.Text = "Apellido :";
            // 
            // comboBoxCargos
            // 
            this.comboBoxCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargos.Enabled = false;
            this.comboBoxCargos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCargos.FormattingEnabled = true;
            this.comboBoxCargos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCargos.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.comboBoxCargos.Location = new System.Drawing.Point(177, 375);
            this.comboBoxCargos.Name = "comboBoxCargos";
            this.comboBoxCargos.Size = new System.Drawing.Size(210, 36);
            this.comboBoxCargos.TabIndex = 31;
            // 
            // textBoxNombreID
            // 
            this.textBoxNombreID.Enabled = false;
            this.textBoxNombreID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreID.Location = new System.Drawing.Point(177, 320);
            this.textBoxNombreID.Name = "textBoxNombreID";
            this.textBoxNombreID.Size = new System.Drawing.Size(210, 35);
            this.textBoxNombreID.TabIndex = 36;
            // 
            // labelNombreID
            // 
            this.labelNombreID.AutoSize = true;
            this.labelNombreID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreID.ForeColor = System.Drawing.Color.Black;
            this.labelNombreID.Location = new System.Drawing.Point(37, 323);
            this.labelNombreID.Name = "labelNombreID";
            this.labelNombreID.Size = new System.Drawing.Size(128, 30);
            this.labelNombreID.TabIndex = 37;
            this.labelNombreID.Text = "NombreID :";
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCambiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiar.ForeColor = System.Drawing.Color.White;
            this.buttonCambiar.Location = new System.Drawing.Point(397, 323);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(159, 34);
            this.buttonCambiar.TabIndex = 38;
            this.buttonCambiar.Text = "Cambiar";
            this.buttonCambiar.UseVisualStyleBackColor = false;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // eliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(632, 612);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.textBoxNombreID);
            this.Controls.Add(this.labelNombreID);
            this.Controls.Add(this.comboBoxCargos);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.buttonCambiarCargo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonOcultar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.labelIdUsuario);
            this.Controls.Add(this.labelEliminarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "eliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEliminarUsuario;
        private System.Windows.Forms.Label labelIdUsuario;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonOcultar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCambiarCargo;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.ComboBox comboBoxCargos;
        private System.Windows.Forms.TextBox textBoxNombreID;
        private System.Windows.Forms.Label labelNombreID;
        private System.Windows.Forms.Button buttonCambiar;
    }
}