using apiParcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Routing.Constraints;

namespace apiParcial3.Clases
{
    public class clsOpeP3
    {
        public clsModP3 objModP3 { get; set; }

        private bool Validar()
        {
            if (objModP3.cantHorW < 0)
            {
                objModP3.Error = "Cantidad de horas no validas";
                return false;
            }
            else if (objModP3.x < 0 && objModP3.h < 0)
            {
                objModP3.Error = "Porcentajes no validos";
                return false;
            }
            else if(objModP3.h < objModP3.x)
            {
                objModP3.Error = "El recargo r1 no puede ser mayor a r2";
                return false;
            }
            else if (objModP3.vrDomic < 0)
            {
                objModP3.Error = "Valor adicional domicilios no valido";
                return false;

            }
            else if (objModP3.cantDomi < 0) 
            {
                objModP3.Error = "Cantidad de domicilios no validas";
                return false;
            }
            return true;
        }

        

        public void HallarPago() {
            if (!Validar())
                return;
            objModP3.salNom = objModP3.vrHora *(float) objModP3.cantHorW;
               
            if (objModP3.cantHorW>=115)
            {
                if (objModP3.cantHorW <= 131)
                {
                    objModP3.salExtHasta16 = objModP3.salNom * (float)(objModP3.x/100);

                }
                else
                {
                    objModP3.salExtMas16 = objModP3.salNom * (float)(objModP3.h/100);
                }
            }
            objModP3.vrDomic = objModP3.vrXDomic * objModP3.cantDomi;
            objModP3.subTot = objModP3.salNom + objModP3.salExtHasta16 + objModP3.salExtMas16;
            objModP3.aPag = objModP3.subTot+objModP3.vrDomic;


        
        }
    }
}