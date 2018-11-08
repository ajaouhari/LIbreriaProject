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

        #region Fields

        private string name;
        private string photo;
        private string description;
        private string address;

        #endregion

        #region Properties

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Photo
        {
            get => photo;
            set => photo = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }

        public Libreria(string name, string photo, string description, string address)
        {
            Name = name;
            Photo = photo;
            Description = description;
            Address = address;
        }





        #endregion

        #region Contrstructor




        #endregion

        #region Public methods

        #endregion

        #region Private Methods

        #endregion

        #region Static Methods

        #endregion





    }
}
