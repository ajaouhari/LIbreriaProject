namespace WindowsFormsApp1
{
    partial class PerfilLibreria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAñadir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditarPerfil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSoporte = new System.Windows.Forms.ToolStripButton();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelHorario = new System.Windows.Forms.Label();
            this.labelListado = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.nombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAñadir,
            this.toolStripSeparator2,
            this.toolStripButtonBorrar,
            this.toolStripSeparator3,
            this.toolStripButtonEditarPerfil,
            this.toolStripSeparator1,
            this.toolStripButtonSoporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAñadir
            // 
            this.toolStripButtonAñadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAñadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAñadir.Name = "toolStripButtonAñadir";
            this.toolStripButtonAñadir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAñadir.Text = "Añadir evento";
            this.toolStripButtonAñadir.Click += new System.EventHandler(this.toolStripButtonAñadir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBorrar
            // 
            this.toolStripButtonBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBorrar.Name = "toolStripButtonBorrar";
            this.toolStripButtonBorrar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBorrar.Text = "Borrar evento";
            this.toolStripButtonBorrar.Click += new System.EventHandler(this.toolStripButtonBorrar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEditarPerfil
            // 
            this.toolStripButtonEditarPerfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditarPerfil.Name = "toolStripButtonEditarPerfil";
            this.toolStripButtonEditarPerfil.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditarPerfil.Text = "Editar perfil";
            this.toolStripButtonEditarPerfil.Click += new System.EventHandler(this.toolStripButtonEditarPerfil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSoporte
            // 
            this.toolStripButtonSoporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSoporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSoporte.Name = "toolStripButtonSoporte";
            this.toolStripButtonSoporte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSoporte.Text = "Soporte con el adminsitrador";
            this.toolStripButtonSoporte.Click += new System.EventHandler(this.toolStripButtonSoporte_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(21, 180);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(21, 212);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(67, 17);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(21, 247);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(64, 17);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(111, 212);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ReadOnly = true;
            this.textBoxDireccion.Size = new System.Drawing.Size(207, 20);
            this.textBoxDireccion.TabIndex = 7;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(110, 245);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(207, 20);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorario.Location = new System.Drawing.Point(21, 278);
            this.labelHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(91, 17);
            this.labelHorario.TabIndex = 9;
            this.labelHorario.Text = "Horario inicio";
            // 
            // labelListado
            // 
            this.labelListado.AutoSize = true;
            this.labelListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListado.Location = new System.Drawing.Point(338, 50);
            this.labelListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListado.Name = "labelListado";
            this.labelListado.Size = new System.Drawing.Size(121, 20);
            this.labelListado.TabIndex = 14;
            this.labelListado.Text = "Listado eventos";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(199, 374);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(118, 24);
            this.buttonGuardar.TabIndex = 15;
            this.buttonGuardar.Text = "Guardar cambios";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Visible = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AllowUserToDeleteRows = false;
            this.dataGridViewEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEvento,
            this.descripcion,
            this.fecha});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEventos.Location = new System.Drawing.Point(339, 72);
            this.dataGridViewEventos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.RowTemplate.Height = 40;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(464, 315);
            this.dataGridViewEventos.TabIndex = 16;
            // 
            // nombreEvento
            // 
            this.nombreEvento.DataPropertyName = "nombreEvento";
            this.nombreEvento.HeaderText = "Nombre evento";
            this.nombreEvento.Name = "nombreEvento";
            this.nombreEvento.ReadOnly = true;
            this.nombreEvento.Width = 174;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 300;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Horario cierre";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Enabled = false;
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(110, 276);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.ShowUpDown = true;
            this.dateTimePickerInicio.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerInicio.TabIndex = 18;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Enabled = false;
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(110, 307);
            this.dateTimePickerFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.ShowUpDown = true;
            this.dateTimePickerFinal.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerFinal.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(111, 337);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(207, 20);
            this.textBoxEmail.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // pictureBoxPerfil
            // 
            this.pictureBoxPerfil.InitialImage = null;
            this.pictureBoxPerfil.Location = new System.Drawing.Point(160, 41);
            this.pictureBoxPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPerfil.Name = "pictureBoxPerfil";
            this.pictureBoxPerfil.Size = new System.Drawing.Size(107, 123);
            this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerfil.TabIndex = 2;
            this.pictureBoxPerfil.TabStop = false;
            this.pictureBoxPerfil.Click += new System.EventHandler(this.pictureBoxPerfil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Editar imagen";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(111, 180);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(207, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // PerfilLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(814, 407);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEventos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelListado);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBoxPerfil);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PerfilLibreria";
            this.Text = "Perfil Libreria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAñadir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditarPerfil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSoporte;
        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labelListado;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}

