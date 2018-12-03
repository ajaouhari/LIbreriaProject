using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Constants;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Utils
{
    public class GeneralMethod
    {
        #region Proprietes



        #endregion

        #region Fields


        #endregion

        #region Constructor

        #endregion

        #region Static Methods

        public static void WriteJSONFile(string filenanme, string JSON, string tipo)
        {

            //using (FileStream fileStream = new FileStream(filenanme, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{

            //    StreamReader streamReader = new StreamReader(fileStream);
            //    StreamWriter streamWriter = new StreamWriter(fileStream);

            //    streamWriter.Write(JSON);
            //    streamWriter.WriteLine();
            //}

            if (tipo.Equals("TipoLibrerias"))
            {
                using (StreamWriter file = File.CreateText(@filenanme))
                {
                    file.Write(JSON);
                }
            }
            else
            {
                File.AppendAllText(filenanme, JSON);
            }
        }

        #endregion

    }
}
