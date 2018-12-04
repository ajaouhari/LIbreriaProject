using Newtonsoft.Json.Linq;
using Perfil_Llibreria;
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

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        List <Usuario> ListaUsuario; 
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Username")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Username";
                textBoxEmail.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.PasswordChar = '·';
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Silver;
                textBoxPassword.PasswordChar = '\0';
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool RevisarEmail = false;

            foreach (Usuario user in ListaUsuario)
            {
                if (textBoxEmail.Text.Equals(user.Username))
                {
                    if (textBoxPassword.Text.Equals(user.Password))
                    {
                        PerfilLibreria EnviarCorreo = new PerfilLibreria(textBoxEmail.Text);
                        this.Hide();
                        EnviarCorreo.ShowDialog();
                        
                        RevisarEmail = true;
                    }
                    else if (textBoxPassword.Text != user.Password)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                        RevisarEmail = true;
                    }
                }
           
            }
            if (RevisarEmail == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\users.json"))
            {
                JArray jArrayUsers = JArray.Parse(File.ReadAllText(@"..\..\users.json"));
                ListaUsuario = jArrayUsers.ToObject<List<Usuario>>();
            }
            else
            {
                ListaUsuario = new List<Usuario>();
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

