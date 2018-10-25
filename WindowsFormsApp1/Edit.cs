using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Edit : Form
    {
        Home rc;
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Home rc) : this()
        {
            this.rc = rc;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
           
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            rc.salir = true;
            this.Close();
            
        }
    }
}
