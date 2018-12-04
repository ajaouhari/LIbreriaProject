namespace WindowsFormsApp1
{
    partial class FormNewEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewEvent));
            this.labelNombreEvento = new System.Windows.Forms.Label();
            this.textBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelFoto = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.dateTimePickerfecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxRutaImg = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreEvento
            // 
            this.labelNombreEvento.AutoSize = true;
            this.labelNombreEvento.Location = new System.Drawing.Point(11, 139);
            this.labelNombreEvento.Name = "labelNombreEvento";
            this.labelNombreEvento.Size = new System.Drawing.Size(97, 13);
            this.labelNombreEvento.TabIndex = 0;
            this.labelNombreEvento.Text = "Nombre del evento";
            this.labelNombreEvento.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNombreEvento
            // 
            this.textBoxNombreEvento.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombreEvento.Location = new System.Drawing.Point(114, 136);
            this.textBoxNombreEvento.Name = "textBoxNombreEvento";
            this.textBoxNombreEvento.Size = new System.Drawing.Size(224, 20);
            this.textBoxNombreEvento.TabIndex = 1;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(71, 162);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(78, 188);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(30, 13);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "Hora";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(55, 217);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Location = new System.Drawing.Point(31, 243);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(77, 13);
            this.labelFoto.TabIndex = 5;
            this.labelFoto.Text = "Foto (opcional)";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(44, 266);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 6;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxDir
            // 
            this.textBoxDir.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDir.Location = new System.Drawing.Point(114, 214);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(224, 20);
            this.textBoxDir.TabIndex = 9;
            // 
            // dateTimePickerfecha
            // 
            this.dateTimePickerfecha.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePickerfecha.Location = new System.Drawing.Point(114, 162);
            this.dateTimePickerfecha.Name = "dateTimePickerfecha";
            this.dateTimePickerfecha.Size = new System.Drawing.Size(224, 20);
            this.dateTimePickerfecha.TabIndex = 12;
            this.dateTimePickerfecha.Value = new System.DateTime(2018, 12, 4, 0, 0, 0, 0);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(114, 188);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(83, 20);
            this.dateTimePickerHora.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAdd.Location = new System.Drawing.Point(252, 380);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Añadir evento";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(171, 380);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExaminar.Location = new System.Drawing.Point(114, 238);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 18;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = false;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(114, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 101);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 19;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxRutaImg
            // 
            this.textBoxRutaImg.Location = new System.Drawing.Point(195, 240);
            this.textBoxRutaImg.Name = "textBoxRutaImg";
            this.textBoxRutaImg.ReadOnly = true;
            this.textBoxRutaImg.Size = new System.Drawing.Size(143, 20);
            this.textBoxRutaImg.TabIndex = 20;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(113, 267);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(225, 107);
            this.textBoxDesc.TabIndex = 21;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // FormNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(367, 407);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxRutaImg);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonExaminar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePickerfecha);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxNombreEvento);
            this.Controls.Add(this.labelNombreEvento);
            this.Name = "FormNewEvent";
            this.Text = "LiberApp - Crear nuevo evento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewEvent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreEvento;
        private System.Windows.Forms.TextBox textBoxNombreEvento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxRutaImg;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}

