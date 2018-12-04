using Newtonsoft.Json;
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
    public partial class FormRegistro : Form
    {
        List<Libreria> libreria;
        public FormRegistro()
        {
            InitializeComponent();
            tbContraseña.PasswordChar = '*';
        }


        private void FormRegistro_Load(object sender, EventArgs e)
        {
            dHorario1.CustomFormat = "HH.mm";
            dHorario2.CustomFormat = "HH.mm";
        }

        //examinar img libreria
        private void bExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivo de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif";

            if (getImage.ShowDialog()== DialogResult.OK) {
                ILogo.BackgroundImage = null;
                ILogo.ImageLocation = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna imágen","Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
//Registrar
        private void bRegistrar_Click(object sender, EventArgs e)
        {
            bool error = false;
    //control intro datos    
          //tel
            if (tbTelefono.Text.Length != 9)
            {
                error = true;
                MessageBox.Show("Introduce correctamente el telefono", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbContraseña.Text.Length < 6)
            {
                error = true;
                MessageBox.Show("La contraseña debe tener minimo 6 caracteres", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //Json

            if (error == false)
            {
                JArray jArrayLibreriaLeer = JArray.Parse(File.ReadAllText(@"..\..\Listalibrerias.json"));
                libreria = jArrayLibreriaLeer.ToObject<List<Libreria>>();


                Libreria NuevaLibreria = new Libreria(tbNombre.Text, tbEmail.Text, tbDireccion.Text, tbTelefono.Text, dHorario1.Value, dHorario2.Value);

                if (!libreria.Contains(NuevaLibreria))
                {
                    libreria.Add(NuevaLibreria);
                    JArray jArrayLibreriaEscribir = (JArray)JToken.FromObject(libreria);

                    StreamWriter fichero = File.CreateText(@"..\..\Listalibrerias.json");
                    JsonTextWriter jsonWriter = new JsonTextWriter(fichero);

                    jArrayLibreriaEscribir.WriteTo(jsonWriter);

                    jsonWriter.Close();

                }
                else
                {
                    MessageBox.Show("Un campo está repetido en una libreria ya creada", "Error");
                }
                
            }
        }

    }
}
