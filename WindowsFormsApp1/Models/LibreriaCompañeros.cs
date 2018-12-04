using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Llibreria
{
    class Libreria:IEquatable<Libreria>
    {

        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFin { get; set; }

        public String Email { get; set; }

        public Libreria()
        {
        }

        public Libreria(string nombre, string email, string direccion, String telefono, DateTime horarioInicio, DateTime horarioFin)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            HorarioInicio = horarioInicio;
            HorarioFin = horarioFin;
            Email = email;
        }

        //public Libreria(string text1, string text2, string text3, DateTime value1, DateTime value2)
        //{
        //}

        public bool Equals(Libreria other)
        {
            Boolean encontrado = false;

            if (this.Email.Equals(other.Email) || this.Nombre.Equals(other.Nombre) || this.Direccion.Equals(other.Direccion))
            {
                encontrado = true;

            }
            return encontrado;
        }
    }
}
