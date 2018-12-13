using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGranosYMas
{
    class separadores
    {
        public int ContadorDeComa(string comp)
        {
            int cantidad = 0;
            for (int i = 0; i < comp.Length - 1; i++)
            {
                if (comp[i].Equals(','))
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        public void LlenarComboBox(ComboBox cb , string comp)
        {
            string pal = "";
            for (int i = 0; i < comp.Length; i++)
            {
                if (comp[i].Equals(','))
                {
                    cb.Items.Add(pal);
                    pal = "";
                }
                else
                {
                    pal += comp[i];
                }
            }
            cb.Items.Add(pal);
        }
        public string Precio(string uni, string precios, string unidades)
        {
            string price="";
            string pal="";
            int coma = 0;
            unidades += ",";
            for (int i = 0; i < unidades.Length; i++)
            {
                if (unidades[i].Equals(','))
                {
                    if (pal.Equals(uni))
                    {
                        price=ObtenerPrecio(coma,precios);
                        i = unidades.Length;
                    }
                    else
                    {
                        coma++;
                    }
                    pal = "";
                }
                else
                {
                    pal += unidades[i];
                }
            }
            return price;
        }
        private string ObtenerPrecio(int coma,string precios)
        {
            string precio = "";
            int cantidad = 0;
            if (coma != 0)
            {
                for (int i = 0; i < precios.Length; i++)
                {
                    if (precios[i].Equals(','))
                    {
                        cantidad++;
                        if (cantidad == coma)
                        {
                            for (int ji = i + 1; ji < precios.Length; ji++)
                            {
                                if (precios[ji] != ',')
                                {
                                    precio += precios[ji];
                                }
                                else
                                {
                                    ji = precios.Length;
                                }
                            }
                        }                       
                    }
                }
            }
            else
            {
                for (int ji = 0 + 1; ji < precios.Length; ji++)
                {
                    if (precios[ji - 1] != ',')
                    {
                        precio += precios[ji - 1];
                    }
                    else
                    {
                        ji = precios.Length;
                    }
                }
            }
                return precio;
        }
    }
}
