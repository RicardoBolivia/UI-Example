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
    public partial class NotasDeEntregaView : Form
    {
        Conexion fn = new Conexion();
        public NotasDeEntregaView(string par, string txtFechaPedido, string txtHoraPedido, string cBEmpresa, string txtNit, string txtFechaEntrega , string txtHoraEntrega, string txtFactura, string txtCanastillos, string txtProyecto)
        {
            InitializeComponent();
            dtProducto.DataSource = fn.llenarGrid("SELECT * FROM granosymas.`pedido` WHERE `Nota de entrega`='" + par + "'");
            txtNotaSalida.Text = par;
            FechaPedidoSalida.Text = txtFechaPedido;
            horaSalida.Text = txtHoraPedido;
            txtEmpresaSalida.Text = cBEmpresa;
            txtNitSalida.Text = txtNit;
            FechaEntregaSalida.Text = txtFechaEntrega;
            HoraSalida2.Text = txtHoraEntrega;
            FacturaSalida.Text = txtFactura;
            CanastillosSalida.Text = txtCanastillos;
            ProyectoSalida.Text = txtProyecto;
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (estado.panel.Controls.Count > 0)
                estado.panel.Controls.RemoveAt(0);
            NotasDeEntregraUI fh = new NotasDeEntregraUI();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            estado.panel.Controls.Add(fh);
            estado.panel.Tag = fh;
            fh.Show();
        }
    }
}
