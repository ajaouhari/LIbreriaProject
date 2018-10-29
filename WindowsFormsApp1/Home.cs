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
            InitializeComponent();
            this.LstLibrerias = new List<Libreria>();
            this.LstUsers = new List<User>();           
        }

        #endregion

        #region Methods
        private void Home_Load(object sender, EventArgs e)
        {

            FillContents.FillLibrary(this.LstLibrerias); 
            
            foreach (var item in this.LstLibrerias)
            {
                LibraryUserControl LUC = new LibraryUserControl(item);
                this.LibraryPanel.Controls.Add(LUC);

            }          
        }


        private void Home_Activated(object sender, EventArgs e)
        {
            if (ConstantText.RefresList) 
            {
                MessageBox.Show("Se han actualizado las librerias");
                ConstantText.RefresList = false;
            }                      
        }
        #endregion
    }
}
