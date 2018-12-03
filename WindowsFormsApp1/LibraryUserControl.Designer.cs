namespace WindowsFormsApp1
{
    partial class LibraryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Editar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar
            // 
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.Location = new System.Drawing.Point(3, 239);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(84, 31);
            this.Editar.TabIndex = 0;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(201, 153);
            this.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPictureBox.TabIndex = 1;
            this.FotoPictureBox.TabStop = false;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(117, 239);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(84, 31);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(85, 174);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(114, 18);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Ejemplo Libreria";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(88, 197);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(109, 18);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Ejemplo libreria";
            // 
            // LibraryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.FotoPictureBox);
            this.Controls.Add(this.Editar);
            this.Name = "LibraryUserControl";
            this.Size = new System.Drawing.Size(207, 279);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Editar;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox FotoPictureBox;
        public System.Windows.Forms.Label Nombre;
        protected System.Windows.Forms.Label Descripcion;
    }
}
