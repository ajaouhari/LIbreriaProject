using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Models
{

    public class Evento //Plantilla para generar los eventos.
    {

        #region Fields

        private string tituloEvento;
        private string direccionLibreria;
        private string fechaCreacionEvento;         //Esta fecha esta oculta, solo se utiliza para tener un registro de eventos creados.
        private string fechaPublicacionEvento;      //Esta fecha es la que indica cuando se va a celebrar el evento.
        private string horaInicioEvento;            //Indica la hora en que se va a iniciar el evento.
        private string descripcionEvento;

        #endregion


        #region Properties

        public string TituloEvento
        {

            get => tituloEvento;
            set => tituloEvento = value;
        }

        public string DireccionLibreria
        {

            get => direccionLibreria;
            set => direccionLibreria = value;
        }

        public string FechaCreacionEvento
        {

            get => fechaCreacionEvento;
            set => fechaCreacionEvento = value;
        }

        public string FechaPublicacionEvento
        {

            get => fechaPublicacionEvento;
            set => fechaPublicacionEvento = value;
        }

        public string HoraInicioEvento
        {

            get => horaInicioEvento;
            set => horaInicioEvento = value;
        }

        public string DescripcionEvento
        {

            get => descripcionEvento;
            set => descripcionEvento = value;
        }

        #endregion


        #region Constructor

        public Evento(string tituloEvento, string direccionLibreria, string fechaPublicacionEvento, string horaInicioEvento, string descripcionEvento)
        {
            TituloEvento = tituloEvento;
            DireccionLibreria = direccionLibreria;
            FechaCreacionEvento = DateTime.Now.ToString(); //Agregamos el formato de fecha larga para tener un registro de publicaciones de eventos.
            FechaPublicacionEvento = fechaPublicacionEvento;
            HoraInicioEvento = horaInicioEvento;
            DescripcionEvento = descripcionEvento;
        }

        #endregion
    }
}
