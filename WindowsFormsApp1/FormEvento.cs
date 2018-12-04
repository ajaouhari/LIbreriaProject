using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Perfil_Llibreria;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNewEvent : Form
    {
        List<Evento> ListaEvento;
        PerfilLibreria perfilLib;
        Evento nuevoEv;

        public FormNewEvent()
        {
            InitializeComponent();
        }

        public FormNewEvent(PerfilLibreria pl)
        {
            this.perfilLib = pl;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivo de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaImg.Text = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            JArray jArrayEventosRead = JArray.Parse(File.ReadAllText(@"..\..\eventos.json"));
            ListaEvento = jArrayEventosRead.ToObject<List<Evento>>();

            Evento NuevoEvento = new Evento(textBoxNombreEvento.Text, textBoxDir.Text, dateTimePickerfecha.Value, dateTimePickerHora.Value, textBoxDesc.Text);
            nuevoEv = NuevoEvento;

            ListaEvento.Add(NuevoEvento);
            JArray jArrayEventoWrite = (JArray)JToken.FromObject(ListaEvento);

            StreamWriter ficheroEventos = File.CreateText(@"..\..\eventos.json");
            JsonTextWriter jsonWriter = new JsonTextWriter(ficheroEventos);

            jArrayEventoWrite.WriteTo(jsonWriter);

            jsonWriter.Close();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            perfilLib.afegirEvent(nuevoEv);
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
