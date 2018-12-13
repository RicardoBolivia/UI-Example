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
    public partial class Nota_de_entrega : Form
    {
        public Nota_de_entrega()
        {
            InitializeComponent();
            
            
        }

        Conexion fn = new Conexion();
        separadores sep = new separadores();
        bool NotaActiva = false;
        bool editar = false;
        int id;

        private void Nota_de_entrega_Load(object sender, EventArgs e)
        {
            dtCliente.DataSource = fn.llenarGrid("select * from clientes");
            dtMemorias.DataSource = fn.llenarGrid("select * from memorias");
            dtProductos.DataSource = fn.llenarGrid("select * from producto");
            int rows = dtCliente.RowCount;
            for (int i = 0; i < rows - 1; i++)
            {
                cBEmpresa.Items.Add(dtCliente[2, i].Value.ToString());
            }
            Meses m = new Meses();
            txtMes.Text = m.literal(DateTime.Today.Month);
            txtFechaEntrega.Value = DateTime.Today;
            txtFechaPedido.Value = DateTime.Today;
            //dtProducto.DataSource = fn.llenarGrid("select * from pedido WHERE `Nota de entrega` = " + txtNotaEntrega.Text);
        }

        #region Botones

        private void NEXT_Click(object sender, EventArgs e)
        {
            if ( (cBEmpresa.Text!= "" ) && (txtProyecto.Text != "" ))
            {
                try
                {
                    IN12.Dock = DockStyle.None;
                    IN12.Visible = false;
                    IN22.Dock = DockStyle.Fill;
                    IN22.Visible = true;
                    txtFactura.Enabled = true;
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
                    #endregion
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.ToString(), "Granos y Mas", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtProducto.RowCount <= 21)
            {
                if (NotaActiva == false)
                {
                    NotaActiva = true;
                }
                if ((txtNotaEntrega.Text != "" ) && ( txtDescripcion.Text != "" ) && ( txtUnidad.Text != "" ) && ( txtCantidadSolicitada.Value.ToString() != "" ) && ( txtCantidadEntregada.Value.ToString() != "" ) && ( txtPrecioUnitario.Text != "" ) && ( fn.DateTimeSQL(txtFechaElaboracion) != "" ) && ( fn.DateTimeSQL(txtfechaVencimiento) != "" ) && ( txtLote.Text != "" ))
                    dtProducto.Rows.Add( txtNotaEntrega.Text , txtDescripcion.Text , txtUnidad.Text , txtCantidadSolicitada.Value.ToString() , txtCantidadEntregada.Value.ToString() , txtPrecioUnitario.Text , fn.DateTimeSQL(txtFechaElaboracion) , fn.DateTimeSQL(txtfechaVencimiento) , txtLote.Text , txtObservaciones.Text );
                else
                    MessageBox.Show("Debe ingresar todos lo campos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                    MessageBox.Show("Alcanzo el limite maximo de productos por nota, debe crear una nota nueva. ", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if(dtProducto.SelectedRows.Count > 0)
            {
                dtProducto.Rows.Remove(dtProducto.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (dtProducto.SelectedRows.Count > 0)
                {
                    editar = true;
                    id = dtProducto.CurrentRow.Index;
                    btnAddPage.Enabled = false;
                    Retornar.Enabled = false;
                    btnEliminarProducto.Enabled = false;
                    btnAgregar.Enabled = false;
                    txtDescripcion.Text = dtProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
                    txtUnidad.Text = dtProducto.CurrentRow.Cells["Unidad"].Value.ToString();
                    txtCantidadEntregada.Text = dtProducto.CurrentRow.Cells["Cantidad entregada"].Value.ToString();
                    txtCantidadSolicitada.Text = dtProducto.CurrentRow.Cells["Cantidad solicitada"].Value.ToString();
                    txtPrecioUnitario.Text = dtProducto.CurrentRow.Cells["Precio Unitario"].Value.ToString();
                    txtLote.Text = dtProducto.CurrentRow.Cells["Lote"].Value.ToString();
                    txtObservaciones.Text = dtProducto.CurrentRow.Cells["Observaciones"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                editar = false;
                string edi = "update pedido set `Nota de entrega` = '" + txtNotaEntrega.Text + "', `Descripcion` = '" + txtDescripcion.Text + "', `Unidad` = '" + txtUnidad.Text + "', `Cantidad solicitada` = '" + txtCantidadSolicitada.Text + "', `Cantidad entregada` = '" + txtCantidadEntregada.Text + "', `Precio unitario` = '" + txtPrecioUnitario.Text + "', `Fecha de elaboracion` = '" + txtFechaElaboracion.Text + "', `Fecha de vencimiento` = '" + txtfechaVencimiento.Text + "', `Lote` = '" + txtLote.Text + "'  where `Id` = '" + id.ToString() + "'";
                dtProducto[1, id].Value = txtDescripcion.Text;
                dtProducto[2, id].Value = txtUnidad.Text;
                dtProducto[3, id].Value = txtCantidadEntregada.Text;
                dtProducto[4, id].Value = txtCantidadSolicitada.Text;
                dtProducto[5, id].Value = txtPrecioUnitario.Text;
                dtProducto[6, id].Value = txtCantidadSolicitada.Text;
                dtProducto[7, id].Value = txtPrecioUnitario.Text;
                dtProducto[8, id].Value = txtLote.Text;
                dtProducto[9, id].Value = txtObservaciones.Text;
                btnAddPage.Enabled = true;
                Retornar.Enabled = true;
                btnEliminarProducto.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }

        private void Retornar_Click_1(object sender, EventArgs e)
        {
            IN22.Dock = DockStyle.None;
            IN22.Visible = false;
            IN12.Dock = DockStyle.Fill;
            IN12.Visible = true;
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            if (dtProducto.Rows.Count != 0)
            {
                #region Guardado de nota de entrega
                string agregar = "INSERT INTO `granosymas`.`notas de entega` (`Numero de nota de entrega`, `Fecha de pedido`, `Hora de pedido`, `Empresa`, `NIT`, `Fecha de entrega`, " +
                                 "`Hora de entrega`, `Factura`, `Canastillos`, `Proyecto`) VALUES ( '" + txtNotaEntrega.Text + "', '" + fn.DateTimeSQL(txtFechaPedido) + "', '" + txtHoraPedido.Value.Hour + ":" + txtHoraPedido.Value.Minute +
                                 "', '" + cBEmpresa.Text + "', '" + txtNit.Text + "', '" + fn.DateTimeSQL(txtFechaEntrega) + "', '" + txtHoraEntrega.Value.Hour + ":" + txtHoraEntrega.Value.Minute + "', '" + txtFactura.Text + "', '" + txtCanastillos.Value + "', '" + txtProyecto.Text + "' )";
                if (!fn.insertar(agregar))
                {
                    MessageBox.Show("Error, Inserte correctamente todos los datos ", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//se guarda la nota  
                string edi = "update memorias set `uNota` = '" + (Convert.ToInt16(txtNotaEntrega.Text) + 1).ToString() + "'  where `Empresa` = '" + cBEmpresa.Text + "'";
                if (!fn.actualizar(edi))
                {
                    MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//se actualiza el numero de nota
                #endregion
                #region Guardado de pedido
                for (int i = 0; i < dtProducto.Rows.Count; i++)
                {
                    if (!fn.insertar("INSERT INTO `granosymas`.`pedido` (`Nota de entrega`, `Descripcion`, `Unidad`, `Cantidad solicitada`, `Cantidad entregada`, `Precio unitario`, `Fecha de elaboracion`, `Fecha de vencimiento`, `Lote`, `Observaciones`) VALUES( '" +
                        dtProducto[0, i].Value.ToString() + "' ,'" + dtProducto[1, i].Value.ToString() + "' ,'" + dtProducto[2, i].Value.ToString() + "' ,'" +
                        dtProducto[3, i].Value.ToString() + "' ,'" + dtProducto[4, i].Value.ToString() + "' ,'" + dtProducto[5, i].Value.ToString() + "' ,'" +
                        dtProducto[6, i].Value.ToString() + "' ,'" + dtProducto[7, i].Value.ToString() + "' ,'" + dtProducto[8, i].Value.ToString() + "' ,'" +
                        dtProducto[9, i].Value.ToString() + "')"))
                    {
                        MessageBox.Show("Error, Inserte correctamente todos los datos ", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion                
                NotaActiva = false;
            }
            else
                MessageBox.Show("Debe insertar por lo menos un producto en la ", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void cBEmpresa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtCliente.DataSource = fn.llenarGrid("select * from clientes where NOMBRE = '" + cBEmpresa.Text + "'");
                txtNit.Text = dtCliente[1, 0].Value.ToString();
                dtCliente.DataSource = fn.llenarGrid("select * from clientes");
                dtMemorias.DataSource = fn.llenarGrid("select * from memorias WHERE Empresa = '" + cBEmpresa.Text + "'");
                txtNotaEntrega.Text = (Convert.ToInt16(dtMemorias[0, 1].Value) + 1).ToString();
                dtProductos.DataSource = fn.llenarGrid("select * from producto where Cliente = '" + cBEmpresa.Text + "'");
                int rows = dtProductos.RowCount;
                for (int i = 0; i < rows - 1; i++)
                {
                    txtDescripcion.Items.Add(dtProductos[1, i].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Granos y Mas", MessageBoxButtons.OK);
            }

        }

        #endregion

        #region Funciones 
        private void FEB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtProductos.DataSource = fn.llenarGrid("select * from producto where Descripcion = '" + txtDescripcion.Text + "'");
                txtfechaVencimiento.Value = txtFechaElaboracion.Value.AddMonths(Convert.ToUInt16(dtProductos[2, 0].Value));
                dtProductos.DataSource = fn.llenarGrid("select * from producto");
                Meses m = new Meses();
                txtLote.Text = m.calendarioJuliano(txtFechaElaboracion.Value.Month, txtFechaElaboracion.Value.Day);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Granos y Mas", MessageBoxButtons.OK);
            }
        }

        private void txtCantidadSolicitada_ValueChanged(object sender, EventArgs e)
        {
            txtCantidadEntregada.Maximum = txtCantidadSolicitada.Value;
        }

        private void txtFechaPedido_ValueChanged(object sender, EventArgs e)
        {
            txtFechaEntrega.MinDate = txtFechaPedido.Value;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtProductos.DataSource = fn.llenarGrid("select * from producto where Descripcion = '" + txtDescripcion.Text + "'");
                sep.LlenarComboBox(txtUnidad, dtProductos[3, 0].Value.ToString());
                dtProductos.DataSource = fn.llenarGrid("select * from producto");
            }
            catch (Exception xe)
            {
            }

        }

        private void txtUnidad_TextChanged(object sender, EventArgs e)
        {
            dtProductos.DataSource = fn.llenarGrid("select * from producto where Descripcion = '" + txtDescripcion.Text + "'");
            txtPrecioUnitario.Text = sep.Precio(txtUnidad.Text, dtProductos[4, 0].Value.ToString(), dtProductos[3, 0].Value.ToString());
            dtProductos.DataSource = fn.llenarGrid("select * from producto");
        }
        #endregion
    }
}
