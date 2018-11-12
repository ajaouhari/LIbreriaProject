using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Constants;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1
{

    public partial class Home : Form
    {

        #region Fields


        #endregion

        #region Properties

        public List<Libreria> LstLibrerias { get; set; }
        public List<User> LstUsers { get; set; }

        #endregion

        #region Constructor
        public Home()
        {
            ConstantText.Home = this;
            InitializeComponent();
            this.LstLibrerias = new List<Libreria>();
            this.LstUsers = new List<User>();
        }

        #endregion

        #region Private Methods
        private void Home_Load(object sender, EventArgs e)
        {


            //Llamo al metodo que rellena el ARRAYLIST de la libreria
            Libreria.FillLibrary(this.LstLibrerias);

            foreach (var item in this.LstLibrerias)
            {
                LibraryUserControl LUC = new LibraryUserControl(item);
                this.LibraryPanel.Controls.Add(LUC);

            }
        }

        //Se ejecuta cuando esta en primer plano el formulario
        private void Home_Activated(object sender, EventArgs e)
        {
            if (ConstantText.RefresList)
            {
                //MessageBox.Show("Se han actualizado las librerias");

                this.LibraryPanel.Refresh();

                    
            }
        }



        #endregion

        #region Public Methods

        public void DelteFromList(int id)
        {

            var itemToRemove = LstLibrerias.Single(r => r.Id == id);
            LstLibrerias.Remove(itemToRemove);

            foreach (LibraryUserControl c in LibraryPanel.Controls)
            {        

                if (c.IdLibreria == id)
                {
                    LibraryPanel.Controls.Remove(c);
                }
            }

            this.LibraryPanel.Refresh();
            
        }
        #endregion
    }
}
