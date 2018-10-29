using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LibraryUserControl : UserControl
    {

        public LibraryUserControl()
        {
            InitializeComponent(); 
            
        }

        public LibraryUserControl(Libreria lb) : this()
        {
            this.Nombre.Text = lb.Name;
            this.Descripcion.Text = lb.Decription;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit editWindows = new Edit();
            editWindows.ShowDialog();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Descripcion.Text, "Le has dado a la libreria", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
