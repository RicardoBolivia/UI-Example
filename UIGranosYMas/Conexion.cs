using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace UIGranosYMas
{
    class Conexion
    {
        MySqlConnection conexion = new MySqlConnection("SERVER= localhost; DATABASE= granosymas; UID= root; PASSWORD=; " +
            "AllowZeroDateTime = True;  ConvertZeroDateTime = True; SslMode = none;");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private DataTable dt;


        public bool Conectar()
        {
            bool conectado = false;
            try
            {
                conexion.Open();
                conectado = true;
            }
            catch (Exception ex)
            {
                conectado = false;
                MessageBox.Show("Error al conectar con la base de datos posiblemente no este corriendo el WampServer. Por favor acepte los permisos de usuario que se mostraran a continuacion.", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conexion.Close();
            }
            return conectado;
        }
        public bool insertar(string consulta)
        {
            bool agregado = false;
            int rows = 0;
            try
            {
                conexion.Open();
                cmd = new MySqlCommand(consulta, conexion);
                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    agregado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conexion.Close();
            }
            return agregado;
        }
        public bool eliminar(string consulta)
        {
            bool eliminado = false;
            int rows = 0;
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                eliminado = true;
            }
            conexion.Close();
            return eliminado;
        }
        //cuando se elimine un cliente se deberia eliminar tambien todos los productos anclados a el
        public bool actualizar(string consulta)
        {
            bool actual = false;
            int rows = 0;
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                actual = true;
            }
            conexion.Close();
            return actual;
        }
        //cuando se actualize la informacionm de un cliente se deberia cambiar tambien todos los productos anclados a el
        public DataTable llenarGrid(string consulta)
        {
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }
        //cuando se elimine un cliente se deberia eliminar tambien todos los productos anclados a el
        public DataTable mostrarUsuarioPorId(string consulta)
        {
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }
        //buscar por nit o nombre
        public string DateTimeSQL(DateTimePicker date)
        {
            string fecha = date.Value.Year + "/" + date.Value.Month + "/" + date.Value.Day;
            return fecha;
        }
    }
}
