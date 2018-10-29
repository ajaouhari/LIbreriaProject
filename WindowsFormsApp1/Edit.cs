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
    public partial class Edit : Form
    {
        public string example = "";

        

        public Edit()
        {
            InitializeComponent();
        }

        //public Edit(bool refresh_List) : this()
        //{
            
        //}

        private void Edit_Load(object sender, EventArgs e)
        {
           
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            ConstantText.RefresList = true;
            this.Close();


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
