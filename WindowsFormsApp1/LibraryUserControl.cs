using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Constants;

namespace WindowsFormsApp1
{
    public partial class LibraryUserControl : UserControl
    {
        #region Properties

        public int IdLibreria { get; set; }
        public string Nombre_libreria;
        public Libreria Lb;

        #endregion

        #region Public Methods

        public LibraryUserControl()
        {
            InitializeComponent();
        }

        public LibraryUserControl(ref Libreria Libreria) : this()
        {
            //Controles
            Nombre.Text = Libreria.Name;
            Descripcion.Text = Libreria.Description;
            FotoPictureBox.Image = Image.FromFile(Libreria.Photo);

            //variables
            IdLibreria = Libreria.Id;
            //Libreria.Photo = string.IsNullOrEmpty(Libreria.Photo) ? @"..\..\Resources\libro.jpg" : Libreria.Photo;
            
            Lb = Libreria;
            
            
        }

        public void RefreshLabels()
        {
            this.Nombre.Text = Lb.Name;
            this.Descripcion.Text = Lb.Description;
            //Foto.Image = Image.FromFile(Lb.Photo);
        }

        #endregion

        #region Private Methods

        private void Button1_Click(object sender, EventArgs e)
        {
            Edit editWindows = new Edit(ref Lb);
            editWindows.ShowDialog();

            RefreshLabels();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar esta libreria?", "¡Atención!", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                if (Lb.Id >= 0)
                {


                    ConstantText.Home.DelteFromList(Lb.Id);
                    

                }
            }
        }

        #endregion

        #region Static Methods

        #endregion

    }
}
