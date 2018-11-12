using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public class Libreria :BaseClass
    {

        #region Fields

        private string name;
        private string photo;
        private string description;
        private string address;
        private int id;

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
        public int Id
        {
            get => id;
            set => id = value;
        }


        #endregion

        #region Contrstructor

        public Libreria(string name, string photo, string description, string address, int id)
        {
            Name = name;
            Photo = photo;
            Description = description;
            Address = address;
            Id = id;
        }

        #endregion

        #region Public methods



        #endregion

        #region Private Methods

        #endregion

        #region Static Methods

        public static void FillLibrary(List<Libreria> LstLibrerias)
        {
            for (int i = 0; i < 50; i++)
            {
                LstLibrerias.Add(new Libreria("Libreria " + i, @"..\..\Resources\libro.jpg", "Libreria " + i, "Libreria " + i, i));
            }

        }
        #endregion

    }
}
