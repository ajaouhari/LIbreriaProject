namespace WindowsFormsApp1
{
    partial class SoporteForm
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
            this.textBoxRemitente = new System.Windows.Forms.TextBox();
            this.labelRemitente = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRemitente
            // 
            this.textBoxRemitente.Location = new System.Drawing.Point(102, 29);
            this.textBoxRemitente.Name = "textBoxRemitente";
            this.textBoxRemitente.Size = new System.Drawing.Size(505, 20);
            this.textBoxRemitente.TabIndex = 0;
            // 
            // labelRemitente
            // 
            this.labelRemitente.AutoSize = true;
            this.labelRemitente.Location = new System.Drawing.Point(30, 36);
            this.labelRemitente.Name = "labelRemitente";
            this.labelRemitente.Size = new System.Drawing.Size(55, 13);
            this.labelRemitente.TabIndex = 1;
            this.labelRemitente.Text = "Remitente";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(102, 74);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(505, 295);
            this.richTextBoxDescripcion.TabIndex = 2;
            this.richTextBoxDescripcion.Text = "";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(125, 406);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 3;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(429, 406);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // SoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.labelRemitente);
            this.Controls.Add(this.textBoxRemitente);
            this.Name = "SoporteForm";
            this.Text = "Incidencia a enviar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRemitente;
        private System.Windows.Forms.Label labelRemitente;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}