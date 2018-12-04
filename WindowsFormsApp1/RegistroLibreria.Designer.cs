namespace WindowsFormsApp1
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.gBDatosLibreria = new System.Windows.Forms.GroupBox();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.bExaminar = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dHorario2 = new System.Windows.Forms.DateTimePicker();
            this.dHorario1 = new System.Windows.Forms.DateTimePicker();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lHorarios = new System.Windows.Forms.Label();
            this.lFotoPerfil = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.ILogo = new System.Windows.Forms.PictureBox();
            this.gBDatosLibreria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ILogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gBDatosLibreria
            // 
            this.gBDatosLibreria.Controls.Add(this.bRegistrar);
            this.gBDatosLibreria.Controls.Add(this.tbContraseña);
            this.gBDatosLibreria.Controls.Add(this.lContraseña);
            this.gBDatosLibreria.Controls.Add(this.bExaminar);
            this.gBDatosLibreria.Controls.Add(this.tbEmail);
            this.gBDatosLibreria.Controls.Add(this.dHorario2);
            this.gBDatosLibreria.Controls.Add(this.dHorario1);
            this.gBDatosLibreria.Controls.Add(this.tbTelefono);
            this.gBDatosLibreria.Controls.Add(this.tbDireccion);
            this.gBDatosLibreria.Controls.Add(this.tbNombre);
            this.gBDatosLibreria.Controls.Add(this.lHorarios);
            this.gBDatosLibreria.Controls.Add(this.lFotoPerfil);
            this.gBDatosLibreria.Controls.Add(this.lEmail);
            this.gBDatosLibreria.Controls.Add(this.lTelefono);
            this.gBDatosLibreria.Controls.Add(this.lDireccion);
            this.gBDatosLibreria.Controls.Add(this.lNombre);
            this.gBDatosLibreria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBDatosLibreria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gBDatosLibreria.Location = new System.Drawing.Point(369, 17);
            this.gBDatosLibreria.Margin = new System.Windows.Forms.Padding(4);
            this.gBDatosLibreria.Name = "gBDatosLibreria";
            this.gBDatosLibreria.Padding = new System.Windows.Forms.Padding(4);
            this.gBDatosLibreria.Size = new System.Drawing.Size(377, 408);
            this.gBDatosLibreria.TabIndex = 0;
            this.gBDatosLibreria.TabStop = false;
            this.gBDatosLibreria.Text = "Datos de la librería";
            // 
            // bRegistrar
            // 
            this.bRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.bRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bRegistrar.Location = new System.Drawing.Point(108, 337);
            this.bRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(245, 41);
            this.bRegistrar.TabIndex = 10;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = false;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(108, 193);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(245, 22);
            this.tbContraseña.TabIndex = 6;
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Location = new System.Drawing.Point(17, 196);
            this.lContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(81, 17);
            this.lContraseña.TabIndex = 14;
            this.lContraseña.Text = "Contraseña";
            // 
            // bExaminar
            // 
            this.bExaminar.Location = new System.Drawing.Point(108, 291);
            this.bExaminar.Margin = new System.Windows.Forms.Padding(4);
            this.bExaminar.Name = "bExaminar";
            this.bExaminar.Size = new System.Drawing.Size(80, 25);
            this.bExaminar.TabIndex = 9;
            this.bExaminar.Text = "Examinar";
            this.bExaminar.UseVisualStyleBackColor = true;
            this.bExaminar.Click += new System.EventHandler(this.bExaminar_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(108, 154);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(245, 22);
            this.tbEmail.TabIndex = 4;
            // 
            // dHorario2
            // 
            this.dHorario2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHorario2.Location = new System.Drawing.Point(244, 237);
            this.dHorario2.Margin = new System.Windows.Forms.Padding(4);
            this.dHorario2.Name = "dHorario2";
            this.dHorario2.ShowUpDown = true;
            this.dHorario2.Size = new System.Drawing.Size(109, 22);
            this.dHorario2.TabIndex = 8;
            // 
            // dHorario1
            // 
            this.dHorario1.CustomFormat = "";
            this.dHorario1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHorario1.Location = new System.Drawing.Point(108, 237);
            this.dHorario1.Margin = new System.Windows.Forms.Padding(4);
            this.dHorario1.Name = "dHorario1";
            this.dHorario1.ShowUpDown = true;
            this.dHorario1.Size = new System.Drawing.Size(108, 22);
            this.dHorario1.TabIndex = 7;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(108, 114);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(245, 22);
            this.tbTelefono.TabIndex = 3;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(108, 73);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(245, 22);
            this.tbDireccion.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(108, 31);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(245, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // lHorarios
            // 
            this.lHorarios.AutoSize = true;
            this.lHorarios.Location = new System.Drawing.Point(17, 244);
            this.lHorarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHorarios.Name = "lHorarios";
            this.lHorarios.Size = new System.Drawing.Size(62, 17);
            this.lHorarios.TabIndex = 5;
            this.lHorarios.Text = "Horarios";
            // 
            // lFotoPerfil
            // 
            this.lFotoPerfil.AutoSize = true;
            this.lFotoPerfil.Location = new System.Drawing.Point(17, 295);
            this.lFotoPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFotoPerfil.Name = "lFotoPerfil";
            this.lFotoPerfil.Size = new System.Drawing.Size(91, 17);
            this.lFotoPerfil.TabIndex = 4;
            this.lFotoPerfil.Text = "Foto de perfil";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(17, 158);
            this.lEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(42, 17);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(17, 118);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(64, 17);
            this.lTelefono.TabIndex = 2;
            this.lTelefono.Text = "Teléfono";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(17, 76);
            this.lDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(67, 17);
            this.lDireccion.TabIndex = 1;
            this.lDireccion.Text = "Dirección";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(16, 34);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(58, 17);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // ILogo
            // 
            this.ILogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ILogo.BackgroundImage")));
            this.ILogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ILogo.InitialImage = null;
            this.ILogo.Location = new System.Drawing.Point(45, 128);
            this.ILogo.Margin = new System.Windows.Forms.Padding(4);
            this.ILogo.Name = "ILogo";
            this.ILogo.Size = new System.Drawing.Size(284, 192);
            this.ILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ILogo.TabIndex = 1;
            this.ILogo.TabStop = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(768, 443);
            this.Controls.Add(this.ILogo);
            this.Controls.Add(this.gBDatosLibreria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.gBDatosLibreria.ResumeLayout(false);
            this.gBDatosLibreria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ILogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBDatosLibreria;
        private System.Windows.Forms.Button bExaminar;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dHorario2;
        private System.Windows.Forms.DateTimePicker dHorario1;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lHorarios;
        private System.Windows.Forms.Label lFotoPerfil;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.PictureBox ILogo;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Button bRegistrar;
    }
}

