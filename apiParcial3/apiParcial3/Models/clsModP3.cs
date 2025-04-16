using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Routing.Constraints;

namespace apiParcial3.Models
{
    public class clsModP3
    {
        #region "Atributos"
        public float vrHora {  get; set; }
        public int cantHorW {  get; set; }

        public float x {  get; set; }
        public int h { get; set; }

        public int cantDomi { get; set; }

        public float vrDomic {  get; set; }

        public float salNom { get; set; }

        public float salExtHasta16 { get; set; }

        public float salExtMas16 {  get; set; }

        public float subTot {  get; set; }

        public float vrXDomic { get; set; }

        public float aPag {  get; set; }

        public string Error { get; set; }  
        #endregion
        public clsModP3() {

            vrHora = 0;
            cantHorW = 0;
            cantDomi = 0;
            salNom = 0;
            salExtHasta16 = 0;
            salExtMas16 = 0;
            subTot = 0;
            vrXDomic = 0;
            aPag = 0;
            x = 0;
            h = 0;
            vrDomic = 0;
            Error = string.Empty;
        }
    }
}