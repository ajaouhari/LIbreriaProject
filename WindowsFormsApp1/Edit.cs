using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Constants;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;


namespace WindowsFormsApp1
{

    public partial class Edit : Form
    {

        #region Fields


        #endregion

        #region Proprietes

        public Libreria Lb;

        #endregion

        #region Constructor
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(ref Libreria lb) : this()
        {             
            fotoPictureBox.ImageLocation = lb.Photo;
            description.Text = lb.Description;
            nombre.Text = lb.Name;
            Lb = lb;
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region  Public Methods


        #endregion

        #region Private Methods

        private void SearchImage_Click(object sender, EventArgs e)
        {
            if (ImageSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sFileName = ImageSelector.FileName;

                fotoPictureBox.ImageLocation = sFileName;

                if (!string.IsNullOrEmpty(sFileName))
                {
                    //Lb.Photo = sFileName;
                }


            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConstantText.RefresList = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(nombre.Text) && string.IsNullOrEmpty(description.Text)))
            {

                Lb.Description = description.Text;
                Lb.Name = nombre.Text;

                string exampole = fotoPictureBox.ImageLocation;
                Lb.Photo = string.IsNullOrEmpty(fotoPictureBox.ImageLocation) ? Lb.Photo : fotoPictureBox.ImageLocation;

                this.Close(); 

            }
            else
            {
                MessageBox.Show("Rellena todos los campos necesarios", "IMPFSDLÑKHSDJFHJKDSHDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
