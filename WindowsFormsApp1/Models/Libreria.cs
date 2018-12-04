using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

            //Utils.GeneralMethod.LstLibreriasVacias();

            Deserialize(@"ListadoLibrerias.JSON", LstLibrerias);

        }

        public static void Deserialize(string fileName, List<Libreria> LstLibrerias)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader file = File.OpenText(fileName))
                {

                    LstLibrerias.AddRange((List<Libreria>)serializer.Deserialize(file, typeof(List<Libreria>)));
                                                       
                }
                    
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        #endregion

    }
}
