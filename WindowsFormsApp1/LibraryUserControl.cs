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
        public int IdLibreria;
        public Libreria Lb;

        public LibraryUserControl()
        {
            InitializeComponent();

        }

        public LibraryUserControl(Libreria lb) : this()
        {
            this.Nombre.Text = lb.Name;
            this.Descripcion.Text = lb.Description;
            this.IdLibreria = lb.Id;
            lb.Photo = string.IsNullOrEmpty(lb.Photo) ? @"C:\Users\bitJavi\Pictures\abdel.jpg" : lb.Photo;
            this.Foto.Image = Image.FromFile(lb.Photo);
            this.Lb = lb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit editWindows = new Edit(Lb);
            editWindows.ShowDialog();


            Nombre.Text = Lb.Name;
            Descripcion.Text = Lb.Description;
            Foto.Image = Image.FromFile(Lb.Photo);

            ConstantText.RefresList = false;


        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Message.", "Title", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (IdLibreria >= 0)
                {
                    ConstantText.Home.DelteFromList(IdLibreria);

                }
            }


        }
    }
}
