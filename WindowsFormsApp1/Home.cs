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

            Libreria.FillLibrary(this.LstLibrerias);

            foreach (var Libreria in this.LstLibrerias)
            {
                var lb = Libreria;
                LibraryUserControl LUC = new LibraryUserControl(ref lb);
                this.LibraryPanel.Controls.Add(LUC);

            }
        }

        //Se ejecuta cuando esta en primer plano el formulario
        private void Home_Activated(object sender, EventArgs e)
        {
            if (ConstantText.RefresList)
            {
                MessageBox.Show("Se han actualizado las librerias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LibraryPanel.Refresh();
                ConstantText.RefresList = false;

                Libreria.SaveLibraryJSON(LstLibrerias);
            }
        }


        #endregion

        #region Public Methods

        public void DelteFromList(int id)
        {
            //Elimina la libreria del array
            var LibreriaEncontrada = LstLibrerias.Single(L => L.Id == id);
            LstLibrerias.Remove(LibreriaEncontrada);

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

        #region Static Methods


        #endregion

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir?", "¡Atención!", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
}
