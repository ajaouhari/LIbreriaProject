namespace WindowsFormsApp1
{
    partial class Edit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchImage = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.ImageSelector = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagen";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Location = new System.Drawing.Point(29, 211);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(331, 183);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 3;
            this.fotoPictureBox.TabStop = false;
            // 
            // SearchImage
            // 
            this.SearchImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchImage.Location = new System.Drawing.Point(143, 161);
            this.SearchImage.Name = "SearchImage";
            this.SearchImage.Size = new System.Drawing.Size(217, 37);
            this.SearchImage.TabIndex = 4;
            this.SearchImage.Text = "Seleccionar imagen...";
            this.SearchImage.UseVisualStyleBackColor = true;
            this.SearchImage.Click += new System.EventHandler(this.SearchImage_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(162, 400);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(117, 36);
            this.Save.TabIndex = 5;
            this.Save.Text = "Guardar cambios";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(285, 400);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 36);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(143, 23);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 20);
            this.nombre.TabIndex = 7;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(143, 49);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(217, 106);
            this.description.TabIndex = 9;
            this.description.Text = "";
            // 
            // ImageSelector
            // 
            this.ImageSelector.FileName = "openFileDialog1";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 448);
            this.Controls.Add(this.description);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SearchImage);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchImage;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.OpenFileDialog ImageSelector;
        public System.Windows.Forms.PictureBox fotoPictureBox;
    }
}