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
    public partial class Home : Form
    {
        public bool salir = false;
        public Home()
        {
            
            InitializeComponent();

            List<Libreria> ListLibrerias = new List<Libreria>();
            //List<UserControl1> ListUserControl = new List<UserControl1>();

            ListLibrerias.Add(new Libreria("Ejemplo1", "Ejemplo1", "Ejemplo1", "Ejemplo1"));
            ListLibrerias.Add(new Libreria("Ejemplo2", "Ejemplo2", "Ejemplo2", "Ejemplo2"));

           

            //rellenamos el arraylist de Usercontrol
            foreach (var item in ListLibrerias)
            {
                UserControl1 fc = new UserControl1(item,this);
                flowLayoutPanel1.Controls.Add(fc);
            }

            //foreach (var item in ListLibrerias)
            //{
            //    string libre = "ali";
            //    if (item.Name.Equals(libre))
            //    {
            //        ListLibrerias.Remove(item);
            //    }
            //}
                
        }

        private void userControl11_click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            if (salir)
            {
                
            }

            Console.WriteLine(this.salir);
        }
    }
}
