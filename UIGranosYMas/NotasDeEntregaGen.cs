using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGranosYMas
{
    public partial class NotasDeEntregaGen : Form
    {
        public NotasDeEntregaGen()
        {
            InitializeComponent();
        }

        Conexion fn = new Conexion();
        separadores sep = new separadores();

        bool NotaActiva = false;
        bool editar = false;
        int id;
        int contProd = 0;

        private void NEXT_Click(object sender, EventArgs e)
        {
            try
            {
                IN12.Dock = DockStyle.None;
                IN12.Visible = false;
                IN22.Dock = DockStyle.Fill;
                IN22.Visible = true;
                #region Traspaso de datos
                txtNotaSalida.Text = txtNotaEntrega.Text;
                FechaPedidoSalida.Value = txtFechaPedido.Value;
                horaSalida.Text = txtHoraPedido.Text;
                txtEmpresaSalida.Text = cBEmpresa.Text;
                txtNitSalida.Text = txtNit.Text;
                txtMesSalida.Text = txtMes.Text;
                FechaEntregaSalida.Text = txtFechaEntrega.Text;
                HoraSalida2.Text = txtHoraEntrega.Text;
                FacturaSalida.Text = txtFactura.Text;
                CanastillosSalida.Text = txtCanastillos.Text;
                ProyectoSalida.Text = txtProyecto.Text;
                dtProducto.DataSource = fn.llenarGrid("select * from pedido WHERE `Nota de entrega`=" + txtNotaEntrega.Text);
                #endregion
                fn.actualizar("update memorias set uNota ='" + (Convert.ToInt16(txtNotaEntrega.Text) + 1).ToString() + "'  where Empresa = '" + cBEmpresa.Text + "'");
            }//debe ser una nota de entrega por cliente entonces cuando se cree el cliente crear un item donde se va a guardar su uNota borrar lole de ahi y la factuara ya nos arreglaremos
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Granos y Mas", MessageBoxButtons.OK);
            }
        }
    }
}
