using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public class Libreria
    {       
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Decription { get; set; }
        public string Address { get; set; }

        public Libreria(string name, string photo, string decription, string address)
        {
            Name = name;
            Photo = photo;
            Decription = decription;
            Address = address;
        }
    }
}
