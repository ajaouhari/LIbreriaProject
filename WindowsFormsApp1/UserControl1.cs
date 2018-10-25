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
    public partial class UserControl1 : UserControl
    {
        Home rc;

        public UserControl1()
        {
            InitializeComponent();
          
        }

        public UserControl1(Libreria lb, Home rc) : this()
        {
            this.Nombre.Text = lb.Name;
            this.Descripcion.Text = lb.Decription;

            this.rc = rc;
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rc.salir = false;
            Console.WriteLine(rc.salir);
            Edit ac = new Edit(rc);
            ac.ShowDialog();
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
