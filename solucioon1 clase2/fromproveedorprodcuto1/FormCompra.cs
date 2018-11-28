using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaNegocio;


namespace formCompra
{
    public partial class FormCompra : Form
    {
        logicaNegocioCompra lN =new logicaNegocioCompra();
        public FormCompra()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();

            try
            {
                Compra objCompra = new Compra();
                objCompra.fecha = txtfecha.Text;
                objCompra.precioC = double.Parse(txtprecioC.Text);
                objCompra.cantidad = int.Parse(txtcantidad.Text);
                objCompra.id_producto = Convert.ToInt32(txtproducto.Text);
                objCompra.idcodigoC = Convert.ToInt32(txtcliente.Text);

                if (lN.insertarCompra(objCompra) > 0)
                {
                    MessageBox.Show("Agregado con éxito!");
                    txtfecha.Text = "";
                    txtprecioC.Text = "";
                    txtcantidad.Text = "";
                    txtproducto.Text = "";
                    txtcliente.Text = "";
                   
                }

                else { MessageBox.Show("Error al agregar proveedor"); }
            }
            catch
            {
                MessageBox.Show("Errorrrrrrr");
            }

        }


        private void FormCompra_Load(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();
            txtID.Visible = false;
            lblidcompra.Visible = false;
            dgvcompra.DataSource = lN.ListarCompras();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
            
            List<Compra> lista = lN.BuscaCompraDatos(txtbuscar.Text);
            dgvcompra.DataSource = lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            txtID.Enabled = false;
            lblidcompra.Visible = true;

            txtfecha.Text = dgvcompra.CurrentRow.Cells["fecha"].Value.ToString();
            txtprecioC.Text = dgvcompra.CurrentRow.Cells["precioC"].Value.ToString();
            txtcantidad.Text = dgvcompra.CurrentRow.Cells["cantidad"].Value.ToString();
            txtID.Text = dgvcompra.CurrentRow.Cells["idcompra"].Value.ToString();
            txtproducto.Text = dgvcompra.CurrentRow.Cells["id_producto"].Value.ToString();
            txtcliente.Text = dgvcompra.CurrentRow.Cells["idcodigoC"].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            btnguardarcom.Text = "Actualizar";
        }

        private void btnguardarcom_Click_1(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();
           Compra objcompra = new Compra();

            try
            {
                if (btnguardarcom.Text == "Guardar")
                {

                    objcompra.fecha = txtfecha.Text;
                    objcompra.precioC = double.Parse(txtprecioC.Text);
                    objcompra.cantidad = int.Parse(txtcantidad.Text);
                    objcompra.id_producto = Convert.ToInt32(txtproducto.Text);
                    objcompra.idcodigoC = Convert.ToInt32(txtcliente.Text);

                    if (lN.insertarCompra(objcompra) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvcompra.DataSource = lN.ListarCompras();
                        txtfecha.Text = "";
                        txtprecioC.Text = "";
                        txtcantidad.Text = "";
                        txtproducto.Text = "";
                        txtcliente.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar compra"); }
                }
                if (btnguardarcom.Text == "Actualizar")
                {

                    objcompra.idcompra = Convert.ToInt32(txtID.Text);
                    objcompra.fecha = txtfecha.Text;
                    objcompra.precioC = double.Parse(txtprecioC.Text);
                    objcompra.cantidad = int.Parse(txtcantidad.Text);
                    objcompra.id_producto = Convert.ToInt32(txtproducto.Text);
                    objcompra.idcodigoC = Convert.ToInt32(txtcliente.Text);
                }

                if (lN.EditarCompra(objcompra) > 0)
                {
                    MessageBox.Show("Actualizado con exito");
                    dgvcompra.DataSource = lN.ListarCompras();
                    txtfecha.Text = "";
                    txtprecioC.Text = "";
                    txtcantidad.Text = "";
                    txtproducto.Text = "";
                    txtcliente.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                }
                else { MessageBox.Show("Error al actualizar compra"); }

                btnguardarcom.Text = "Guardar";

            }

            catch
            {
                MessageBox.Show("Errorrrrrr!");
            }
        }

        private void btneliminarc_Click(object sender, EventArgs e)
        {
            int idcompra = Convert.ToInt32(dgvcompra.CurrentRow.Cells["idcompra"].Value.ToString());

            try
            {
                if (lN.EliminarCompra(idcompra) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dgvcompra.DataSource = lN.ListarCompras();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar Compra");
            }
        }

        }
    }

