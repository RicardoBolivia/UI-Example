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
    public partial class NotasDeEntregraUI : Form
    {
        Conexion fn = new Conexion();
        separadores sep = new separadores();
        bool buscar = false;
        string bus;
        public NotasDeEntregraUI()
        {
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (estado.panel.Controls.Count > 0)
                estado.panel.Controls.RemoveAt(0);
            Nota_de_entrega fh = new Nota_de_entrega();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            estado.panel.Controls.Add(fh);
            estado.panel.Tag = fh;
            fh.Show();
        }

        private void NotasDeEntregraUI_Load(object sender, EventArgs e)
        {
            dtNotas.DataSource = fn.llenarGrid("SELECT * FROM granosymas.`notas de entega`");
        }

        private void btbBuscar_Click(object sender, EventArgs e)
        {
            if (!buscar)
            {
                desplegar();
                buscar = true;
            }
        }

        private void desplegar()
        {
            if (!buscar)
            {
                subMenuBuscar.Visible = true;
            }
            else
            {
                subMenuBuscar.Visible = false;
                if (busNot.Checked)
                {
                    string not = Microsoft.VisualBasic.Interaction.InputBox("Buscar por Nota de Entrega", "Granos y Mas", "0000");
                    dtNotas.DataSource = fn.llenarGrid("SELECT * FROM granosymas.`notas de entega` where `Numero de nota de entega` = '" + bus + "'");
                }
                else
                {
                    string not = Microsoft.VisualBasic.Interaction.InputBox("Buscar por Empresa", "Granos y Mas", "Ingrese una empresa");
                    dtNotas.DataSource = fn.llenarGrid("SELECT * FROM granosymas.`notas de entega` where Empresa = '" + bus + "'");
                }
                buscar = false;
            }
        }

        private void busNot_CheckedChanged(object sender, EventArgs e)
        {
            desplegar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dtNotas.SelectedRows.Count > 0)
            {
                if (estado.panel.Controls.Count > 0)
                    estado.panel.Controls.RemoveAt(0);
                string txtNotaEntrega = dtNotas.CurrentRow.Cells["Numero de nota de entrega"].Value.ToString();
                string txtFechaPedido = dtNotas.CurrentRow.Cells["Fecha de pedido"].Value.ToString();
                string txtHoraPedido = dtNotas.CurrentRow.Cells["Hora de pedido"].Value.ToString();
                string cBEmpresa = dtNotas.CurrentRow.Cells["Empresa"].Value.ToString();
                string txtNit = dtNotas.CurrentRow.Cells["NIT"].Value.ToString();
                string txtFechaEntrega = dtNotas.CurrentRow.Cells["Fecha de entrega"].Value.ToString();
                string txtHoraEntrega = dtNotas.CurrentRow.Cells["Hora de entrega"].Value.ToString();
                string txtFactura = dtNotas.CurrentRow.Cells["Factura"].Value.ToString();
                string txtCanastillos = dtNotas.CurrentRow.Cells["Canastillos"].Value.ToString();
                string txtProyecto = dtNotas.CurrentRow.Cells["Proyecto"].Value.ToString();
                NotasDeEntregaView fh = new NotasDeEntregaView(txtNotaEntrega, txtFechaPedido, txtHoraPedido, cBEmpresa, txtNit, txtFechaEntrega, txtHoraEntrega, txtFactura, txtCanastillos, txtProyecto);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                estado.panel.Controls.Add(fh);
                estado.panel.Tag = fh;
                fh.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            if (dtNotas.SelectedRows.Count > 0)
            {
                string id = dtNotas.CurrentRow.Cells["Numero de nota de entrega"].Value.ToString();
                if (fn.eliminar("delete FROM granosymas.`notas de entega` where 'Numero de nota de entrega'= " + id))
                {
                    MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtNotas.DataSource = fn.llenarGrid("SELECT * FROM granosymas.`notas de entega`");
                }
                else
                {
                    MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dtNotas.DataSource = fn.llenarGrid("SELECT * FROM granosymas.`notas de entega`");
        }
    }
}

