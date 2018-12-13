using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGranosYMas
{
    class Meses
    {
        public string literal(int n)
        {
            string mes = "Error";
            switch (n)
            {
                case 1:
                    {
                        mes = "Enero";
                    }
                    break;
                case 2:
                    {
                        mes = "Febrero";
                    }
                    break;
                case 3:
                    {
                        mes = "Marzo";
                    }
                    break;
                case 4:
                    {
                        mes = "Abril";
                    }
                    break;
                case 5:
                    {
                        mes = "Mayo";
                    }
                    break;
                case 6:
                    {
                        mes = "Junio";
                    }
                    break;
                case 7:
                    {
                        mes = "Julio";
                    }
                    break;
                case 8:
                    {
                        mes = "Agosto";
                    }
                    break;
                case 9:
                    {
                        mes = "Septiembre";
                    }
                    break;
                case 10:
                    {
                        mes = "Octubre";
                    }
                    break;
                case 11:
                    {
                        mes = "Noviembre";
                    }
                    break;
                case 12:
                    {
                        mes = "Diciembre";
                    }
                    break;
            }
            return mes;
        }
        public string calendarioJuliano(int me, int n)
        {
            int mes = 0;
            switch (me)
            {
                case 1:
                    {
                        mes = n ;
                    }
                    break;
                case 2:
                    {
                        mes = n + 31;
                    }
                    break;
                case 3:
                    {
                        mes = n + 59;
                    }
                    break;
                case 4:
                    {
                        mes = n + 90;
                    }
                    break;
                case 5:
                    {
                        mes = n + 120;
                    }
                    break;
                case 6:
                    {
                        mes = n + 151;
                    }
                    break;
                case 7:
                    {
                        mes = n + 181;
                    }
                    break;
                case 8:
                    {
                        mes = n + 212;
                    }
                    break;
                case 9:
                    {
                        mes = n + 243;
                    }
                    break;
                case 10:
                    {
                        mes = n + 273;
                    }
                    break;
                case 11:
                    {
                        mes = n + 304;
                    }
                    break;
                case 12:
                    {
                        mes = n + 334;
                    }
                    break;
            }
            return mes.ToString();
        }
    }
}
