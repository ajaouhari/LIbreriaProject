using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class SoporteForm : Form
    {
        public SoporteForm()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (textBoxRemitente.Text != null && richTextBoxDescripcion.Text != null)
            {

                Soporte soporte = new Soporte(98, textBoxRemitente.Text, richTextBoxDescripcion.Text); //Falca configurar el ID.

                soporte.SaveSuportJSON(soporte);
            }
            else
            {

                MessageBox.Show("Rellene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
    }
}
