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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        Conexion fn = new Conexion();
        bool bEditar = false;
        bool buscar = false;
        int id = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (bEditar==false)
            {
                string agregar = "insert into clientes(NIT, NOMBRE) values (" + txtNit.Text + ", '" + txtNombre.Text + "')";
                if (fn.insertar(agregar))
                {
                    fn.insertar("INSERT INTO `granosymas`.`memorias` (`Empresa`, `uNota`) VALUES('" + txtNombre.Text + "', '0')");
                }
                else
                {
                    MessageBox.Show("Error al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                valOinval();
                reactivar();
            }
            else
            {
                string editar = "update clientes set nit =" + txtNit.Text + ", NOMBRE = '" + txtNombre.Text + "'  where Id = '" + id.ToString() + "'";
                if (fn.actualizar(editar))
                {
                    fn.insertar("UPDATE `granosymas`.`memorias` SET `Empresa` = '" + txtNombre.Text + "', '0')");
                }
                else
                {
                    MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.DataSource = fn.llenarGrid("select * from clientes");
                bEditar = false;
                reactivar();
                valOinval();
            }

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fn.llenarGrid("select * from clientes");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            valOinval();
            btnEditar.Enabled = false;
            btbEliminar.Enabled = false;
            btbBuscar.Enabled = false;
            refresh.Enabled = false;
        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {                
                id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                if (fn.eliminar("delete from clientes where Id= " + id.ToString()))
                {
                    MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.DataSource = fn.llenarGrid("select * from clientes");
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                txtNit.Text = dataGridView1.CurrentRow.Cells["NIT"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                id = Convert.ToInt16( dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
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
                dataGridView1.DataSource = fn.llenarGrid("select * from clientes");
                gbDatos.Enabled = false;
                btnAgregar.Visible = false;
                btnNuevo.Visible = true;
                txtNombre.Clear();
                txtNit.Clear();
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
                if ((txtNit.Enabled && txtNit.Text != "") || (txtNombre.Enabled && txtNombre.Text != ""))
                {
                    if (busNit.Checked)
                    {
                        dataGridView1.DataSource = fn.llenarGrid("select * from clientes where NIT = " + txtNit.Text);
                        txtNit.Enabled = true;
                        txtNit.Clear();
                    }
                    else
                    {
                        dataGridView1.DataSource = fn.llenarGrid("select * from clientes where NOMBRE = '" + txtNombre.Text + "'");
                        txtNombre.Clear();
                        txtNombre.Enabled = true;
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
                if (busNit.Checked)
                {
                    gbDatos.Enabled = true;
                    txtNombre.Enabled = false;
                }
                else
                {
                    gbDatos.Enabled = true;
                    txtNit.Enabled = false;
                }
            }
        }

        private void busNit_Click(object sender, EventArgs e)
        {
            buscar = true;
            desplegar();
        }

        private void busNom_Click(object sender, EventArgs e)
        {
            buscar = true;
            desplegar();
        }

        private void reactivar()
        {
            btnEditar.Enabled = true;
            btbEliminar.Enabled = true;
            btbBuscar.Enabled = true;
            refresh.Enabled = true;
            btnNuevo.Enabled = true;
            txtNit.Enabled = true;
            txtNombre.Enabled = true;
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = fn.llenarGrid("select * from clientes");
            txtNombre.Clear();
            txtNit.Clear();

        }
    }
}
