using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Models
{

    public class Soporte
    {

        #region Fields

        private int     id;
        private string  remitente;
        private string  descripcion;



        #endregion

        #region Propierties

        public int Id
        {

            get => id;
            set => id = value;
        }

        public string Remitente
        {

            get => remitente;
            set => remitente = value;
        }

        public string Descripcion
        {

            get => descripcion;
            set => descripcion = value;
        }

        #endregion

        #region Constructor

        public Soporte(int id, string remitente, string descripcion)
        {
            this.id = id;
            this.remitente = remitente;
            this.descripcion = descripcion;
        }

        #endregion

        #region Public Methods

        public void SaveSuportJSON(Soporte soporte)
        {

            string json = JsonConvert.SerializeObject(soporte);


            Utils.GeneralMethod.WriteJSONFile("Incidencias.JSON", json, "TipoSoporte");
        }

        #endregion

        #region Private Methods




        #endregion

        #region Static Methods
        #endregion
    }
}
