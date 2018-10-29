using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Constants;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Utils
{
    public class FillContents
    {
        #region Proprietes



        #endregion

        #region Fields


        #endregion

        #region Constructor

        #endregion

        #region Methods

        public static void FillLibrary(List<Libreria> LstLibrerias)
        {
            for (int i = 0; i < 50; i++)
            {
                LstLibrerias.Add(new Libreria("Libreria " + i, "Libreria " + i, "Libreria " + i, "Libreria " + i));
            }
                    
        }
        #endregion

    }
}
