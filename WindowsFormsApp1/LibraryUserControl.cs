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
        public Libreria Lb;

        #endregion

        #region Public Methods

        public LibraryUserControl()
        {
            InitializeComponent();
        }

        public LibraryUserControl(ref Libreria lb) : this()
        {
            IdLibreria = lb.Id;
            Nombre.Text = lb.Name;
            Descripcion.Text = lb.Description;
            //lb.Photo = string.IsNullOrEmpty(lb.Photo) ? @"C:\Users\bitJavi\Pictures\abdel.jpg" : lb.Photo;
            //this.Foto.Image = Image.FromFile(lb.Photo);
            Lb = lb;
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
