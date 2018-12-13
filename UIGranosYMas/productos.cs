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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        Conexion fn = new Conexion();
        separadores sep = new separadores();
        bool bEditar = false;
        bool buscar = false;
        int id = 0;
        private void productos_Load(object sender, EventArgs e)
        {
            dtProducto.DataSource = fn.llenarGrid("select * from producto");
            dtCliente.DataSource = fn.llenarGrid("select * from clientes");
            int rows = dtCliente.RowCount;
            for (int i = 0; i < rows - 1; i++)
            {
                cbCliente.Items.Add(dtCliente[2, i].Value.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            valOinval();
            btnEditar.Enabled = false;
            btbEliminar.Enabled = false;
            btbBuscar.Enabled = false;
            refresh.Enabled = false;
        } 

        private void valOinval()
        {
            if (gbDatos.Enabled == false)
            {
                gbDatos.Enabled = true;
                btnAgregar.Visible = true;
                btnNuevo.Visible = false;
            }
            else
            {
                dtProducto.DataSource = fn.llenarGrid("select * from producto");
                gbDatos.Enabled = false;
                btnAgregar.Visible = false;
                btnNuevo.Visible = true;
                txtNombre.Clear();
                txtPrecioU.Clear();
                txtUnidad.Clear();
                cbCliente.Text = "";
                txtDuracion.Text = "0";
            }
        }

        private void reactivar()
        {
            btnEditar.Enabled = true;
            btbEliminar.Enabled = true;
            btbBuscar.Enabled = true;
            refresh.Enabled = true;
            btnNuevo.Enabled = true;
            txtDuracion.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecioU.Enabled = true;
            cbCliente.Enabled = true;
            txtUnidad.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (bEditar == false)
            {
                if (sep.ContadorDeComa(txtPrecioU.Text)==sep.ContadorDeComa(txtUnidad.Text))
                {
                    string agregar = "insert into producto(Descripcion, Duracion, Unidad, PrecioUnitario, Cliente) values ('" + txtNombre.Text + "', '" +
                        txtDuracion.Text + "','" + txtUnidad.Text + "', '" + txtPrecioU.Text + "', '" + cbCliente.Text + "')";
                    if (fn.insertar(agregar))
                    {
                        MessageBox.Show("Exito al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    valOinval();
                    reactivar();
                }
            }
            else
            {

                string editar = "update producto set Descripcion ='" + txtNombre.Text + "', Duracion = '" + txtDuracion.Text + "', Unidad = '" + 
                    txtUnidad.Text + "', PrecioUnitario = '" + txtPrecioU.Text + "', Cliente = '" + cbCliente.Text + "'  where Id =' " + id.ToString() +"'" ;
                if (fn.actualizar(editar))
                {
                    MessageBox.Show("Exito al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtProducto.DataSource = fn.llenarGrid("select * from producto");
                bEditar = false;
                reactivar();
                valOinval();
            }
        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            if (dtProducto.SelectedRows.Count > 0)
            {
                id = Convert.ToInt16(dtProducto.CurrentRow.Cells["Id"].Value.ToString());
                if (fn.eliminar("delete from producto where Id= " + id.ToString()))
                {
                    MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtProducto.DataSource = fn.llenarGrid("select * from producto");
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtProducto.SelectedRows.Count > 0)
            {
                txtDuracion.Text = dtProducto.CurrentRow.Cells["Duracion"].Value.ToString();
                txtNombre.Text = dtProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtUnidad.Text = dtProducto.CurrentRow.Cells["Unidad"].Value.ToString();
                txtPrecioU.Text = dtProducto.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
                cbCliente.Text = dtProducto.CurrentRow.Cells["Cliente"].Value.ToString();
                id = Convert.ToInt16(dtProducto.CurrentRow.Cells["Id"].Value.ToString());
                bEditar = true;
                valOinval();
                btnEditar.Enabled = false;
                btbEliminar.Enabled = false;
                btbBuscar.Enabled = false;
                refresh.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btbBuscar_Click(object sender, EventArgs e)
        {
            if (buscar == false)
            {
                desplegar();
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                btbEliminar.Enabled = false;
                refresh.Enabled = false;
            }
            else
            {
                if ((cbCliente.Enabled && cbCliente.Text != "") || (txtNombre.Enabled && txtNombre.Text != ""))
                {
                    if (busCliente.Checked)
                    {
                        dtProducto.DataSource = fn.llenarGrid("select * from producto where Cliente = '" + cbCliente.Text + "'");
                        cbCliente.Text="";
                        busCliente.Checked = false;
                    }
                    else
                    {
                        dtProducto.DataSource = fn.llenarGrid("select * from producto where Descripcion = '" + txtNombre.Text + "'");
                        txtNombre.Clear();
                        txtNombre.Enabled = true;
                        busNom.Checked = false;
                    }
                    gbDatos.Enabled = false;
                    reactivar();
                    buscar = false;
                }
            }
        }

        private void desplegar()
        {
            if (buscar == false)
            {
                subMenuBuscar.Visible = true;
            }
            else
            {
                subMenuBuscar.Visible = false;
                if (busCliente.Checked)
                {
                    gbDatos.Enabled = true;
                    txtDuracion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPrecioU.Enabled = false;
                    txtUnidad.Enabled = false;
                }
                else
                {
                    gbDatos.Enabled = true;
                    txtDuracion.Enabled = false;
                    txtPrecioU.Enabled = false;
                    cbCliente.Enabled = false;
                    txtUnidad.Enabled = false;
                }
            }
        }

        private void busNom_CheckedChanged(object sender, EventArgs e)
        {
            buscar = true;
            desplegar();
        }

        private void busCliente_CheckedChanged(object sender, EventArgs e)
        {
            buscar = true;
            desplegar();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dtProducto.DataSource = fn.llenarGrid("select * from producto");
            txtNombre.Clear();
            cbCliente.Text="";
        }
    }
}
