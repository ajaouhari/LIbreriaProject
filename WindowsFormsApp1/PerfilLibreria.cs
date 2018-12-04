using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using Eventos;

namespace WindowsFormsApp1
{
    
    public partial class PerfilLibreria : Form
    {
        Libreria libActual;
        BindingList<Evento> evento;
        List<Libreria> libreria;


        public PerfilLibreria()
        {
            InitializeComponent();
        }

        public PerfilLibreria(string CorreoElectronico)
        {
            InitializeComponent();
            textBoxEmail.Text = CorreoElectronico;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerInicio.CustomFormat = "HH.mm";
            dateTimePickerFinal.CustomFormat = "HH.mm";
            // Eventos

            dataGridViewEventos.AutoGenerateColumns = false;
            if (File.Exists(@"..\..\eventos.json"))
            {
                JArray jArrayEventos = JArray.Parse(File.ReadAllText(@"..\..\eventos.json"));
                evento = jArrayEventos.ToObject<BindingList<Evento>>();
                dataGridViewEventos.DataSource = null;
                dataGridViewEventos.DataSource = evento;
            }
            else
            {
                evento = new BindingList<Evento>();

            }

            // Llibreria

            
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(@"..\..\Listalibrerias.json"));
            libreria = jArrayLibrerias.ToObject<List<Libreria>>();
           


            foreach (Libreria lib in libreria)
            {
                if (textBoxEmail.Text.Equals(lib.Email))
                {
                    textBoxDireccion.Text = lib.Direccion;
                    textBoxNombre.Text = lib.Nombre;
                    textBoxTelefono.Text = lib.Telefono;
                    dateTimePickerFinal.Value = lib.HorarioFin;
                    dateTimePickerInicio.Value = lib.HorarioInicio;
                    this.libActual = lib;
                    
                }

            }
            
        }

        private void toolStripButtonEditarPerfil_Click(object sender, EventArgs e)
        {
            textBoxDireccion.ReadOnly = false;
            dateTimePickerInicio.Enabled = true;
            dateTimePickerFinal.Enabled = true;
            textBoxNombre.ReadOnly = false;
            textBoxTelefono.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            buttonGuardar.Visible = true;


        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            textBoxDireccion.ReadOnly = true;
            dateTimePickerInicio.Enabled = false;
            dateTimePickerFinal.Enabled = false;
            textBoxNombre.ReadOnly = true;
            textBoxTelefono.ReadOnly = true;
            buttonGuardar.Visible = false;
            textBoxEmail.ReadOnly = true;

            foreach (Libreria lib in libreria)
            {
                if (textBoxEmail.Text.Equals(lib.Email))
                {
                    lib.Direccion = textBoxDireccion.Text;
                    lib.Email = textBoxEmail.Text;
                    lib.Nombre = textBoxNombre.Text;
                    lib.Telefono = textBoxTelefono.Text;
                    lib.HorarioFin = dateTimePickerFinal.Value;
                    lib.HorarioInicio = dateTimePickerInicio.Value;

                    JArray jArrayLibreriaEscribir = (JArray)JToken.FromObject(libreria);

                    StreamWriter fichero = File.CreateText(@"..\..\Listalibrerias.json");
                    JsonTextWriter jsonWriter = new JsonTextWriter(fichero);


                    jArrayLibreriaEscribir.WriteTo(jsonWriter);

                    jsonWriter.Close();
                }
            }

        }

        private void pictureBoxPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.ShowDialog();
       
            pictureBoxPerfil.ImageLocation = openFile.FileName;
        }

        private void toolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            evento.Remove((Evento)dataGridViewEventos.SelectedRows[0].DataBoundItem);

            dataGridViewEventos.DataSource = null;
            dataGridViewEventos.DataSource = evento;

            JArray jArrayEventoEscribir = (JArray)JToken.FromObject(evento);

            StreamWriter fichero = File.CreateText(@"..\..\eventos.json");
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);


            jArrayEventoEscribir.WriteTo(jsonWriter);

            jsonWriter.Close();
        }

        private void toolStripButtonAñadir_Click(object sender, EventArgs e)
        {
            FormNewEvent OpenEvent = new FormNewEvent(this);
            OpenEvent.ShowDialog();
        }

        public void afegirEvent(Evento ev)
        {
            evento.Add(ev);
            dataGridViewEventos.DataSource = null;
            dataGridViewEventos.DataSource = evento;

        }

        private void toolStripButtonSoporte_Click(object sender, EventArgs e)
        {

        }
    }
}
