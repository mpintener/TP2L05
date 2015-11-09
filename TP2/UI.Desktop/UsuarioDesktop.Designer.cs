namespace UI.Desktop
    {
    partial class UsuarioDesktop
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIDPersona = new System.Windows.Forms.Label();
            this.txtConfirmarNuevaClave = new System.Windows.Forms.TextBox();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.lblNuevaClave = new System.Windows.Forms.Label();
            this.lblConfirmarNuevaClave = new System.Windows.Forms.Label();
            this.chkCambiarClave = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mtbIDPersona = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(155, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(126, 81);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(155, 20);
            this.txtClave.TabIndex = 3;
            this.txtClave.Tag = "Clave";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(28, 91);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(126, 55);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.Tag = "NombreUsuario";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(126, 107);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(155, 20);
            this.txtConfirmarClave.TabIndex = 4;
            this.txtConfirmarClave.Tag = "ConfirmarClave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(28, 114);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(78, 13);
            this.lblConfirmarClave.TabIndex = 13;
            this.lblConfirmarClave.Text = "ConfirmarClave";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(325, 32);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 5;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(232, 148);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(323, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIDPersona
            // 
            this.lblIDPersona.AutoSize = true;
            this.lblIDPersona.Location = new System.Drawing.Point(322, 114);
            this.lblIDPersona.Name = "lblIDPersona";
            this.lblIDPersona.Size = new System.Drawing.Size(60, 13);
            this.lblIDPersona.TabIndex = 17;
            this.lblIDPersona.Text = "ID Persona";
            // 
            // txtConfirmarNuevaClave
            // 
            this.txtConfirmarNuevaClave.Location = new System.Drawing.Point(444, 84);
            this.txtConfirmarNuevaClave.Name = "txtConfirmarNuevaClave";
            this.txtConfirmarNuevaClave.ReadOnly = true;
            this.txtConfirmarNuevaClave.Size = new System.Drawing.Size(155, 20);
            this.txtConfirmarNuevaClave.TabIndex = 8;
            this.txtConfirmarNuevaClave.Tag = "ConfirmarNuevaClave";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(444, 55);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.ReadOnly = true;
            this.txtNuevaClave.Size = new System.Drawing.Size(155, 20);
            this.txtNuevaClave.TabIndex = 7;
            this.txtNuevaClave.Tag = "NuevaClave";
            // 
            // lblNuevaClave
            // 
            this.lblNuevaClave.AutoSize = true;
            this.lblNuevaClave.Location = new System.Drawing.Point(322, 62);
            this.lblNuevaClave.Name = "lblNuevaClave";
            this.lblNuevaClave.Size = new System.Drawing.Size(69, 13);
            this.lblNuevaClave.TabIndex = 20;
            this.lblNuevaClave.Text = "Nueva Clave";
            // 
            // lblConfirmarNuevaClave
            // 
            this.lblConfirmarNuevaClave.AutoSize = true;
            this.lblConfirmarNuevaClave.Location = new System.Drawing.Point(322, 91);
            this.lblConfirmarNuevaClave.Name = "lblConfirmarNuevaClave";
            this.lblConfirmarNuevaClave.Size = new System.Drawing.Size(116, 13);
            this.lblConfirmarNuevaClave.TabIndex = 21;
            this.lblConfirmarNuevaClave.Text = "Confirmar Nueva Clave";
            // 
            // chkCambiarClave
            // 
            this.chkCambiarClave.AutoSize = true;
            this.chkCambiarClave.Location = new System.Drawing.Point(444, 31);
            this.chkCambiarClave.Name = "chkCambiarClave";
            this.chkCambiarClave.Size = new System.Drawing.Size(94, 17);
            this.chkCambiarClave.TabIndex = 6;
            this.chkCambiarClave.Text = "Cambiar Clave";
            this.chkCambiarClave.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(605, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mtbIDPersona
            // 
            this.mtbIDPersona.Location = new System.Drawing.Point(444, 111);
            this.mtbIDPersona.Mask = "99999";
            this.mtbIDPersona.Name = "mtbIDPersona";
            this.mtbIDPersona.Size = new System.Drawing.Size(155, 20);
            this.mtbIDPersona.TabIndex = 9;
            this.mtbIDPersona.Tag = "IDPersona";
            this.mtbIDPersona.ValidatingType = typeof(int);
            // 
            // UsuarioDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 183);
            this.Controls.Add(this.mtbIDPersona);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkCambiarClave);
            this.Controls.Add(this.lblConfirmarNuevaClave);
            this.Controls.Add(this.lblNuevaClave);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.txtConfirmarNuevaClave);
            this.Controls.Add(this.lblIDPersona);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIDPersona;
        private System.Windows.Forms.TextBox txtConfirmarNuevaClave;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label lblNuevaClave;
        private System.Windows.Forms.Label lblConfirmarNuevaClave;
        private System.Windows.Forms.CheckBox chkCambiarClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mtbIDPersona;
        
        }
    }