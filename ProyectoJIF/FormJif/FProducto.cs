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

namespace FormJif
{
    public partial class FProducto : Form
    {
        public FProducto()
        {
            InitializeComponent();
        }
        logicaNegocioProducto lN = new logicaNegocioProducto();
        private void btnguardarproducto_Click(object sender, EventArgs e)
        {
            
            try
            {
                Producto objproducto = new Producto();
                objproducto.nombre = txtnombre.Text;
                objproducto.marca = txtmarca.Text;
                objproducto.precio = double.Parse(txtprecio.Text);

                if (lN.insertarProducto(objproducto) > 0)
                {
                    MessageBox.Show("Agregado con exito!");
                    txtnombre.Text = "";
                    txtmarca.Text = "";
                    txtprecio.Text = "";
                }
                else { MessageBox.Show("Error al agregar producto"); }
            }
            catch 
            {
                MessageBox.Show("Errorrrrrr");
            }
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            lblid.Visible = false;
            dgvproducto.DataSource = lN.ListarProductos();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            List<Producto> Lista = lN.BuscaProductoDatos(txtbuscar.Text);
            dgvproducto.DataSource = Lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true;

            txtnombre.Text = dgvproducto.CurrentRow.Cells["nombre"].Value.ToString();
            txtmarca.Text = dgvproducto.CurrentRow.Cells["marca"].Value.ToString();
            txtprecio.Text = dgvproducto.CurrentRow.Cells["precio"].Value.ToString();
            txtid.Text = dgvproducto.CurrentRow.Cells["id_producto"].Value.ToString();

            tabControlproducto.SelectedTab = tpregistrar;
            btnguardarproducto.Text = "Actualizar";


        }

        private void btnguardarproducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(btnguardarproducto.Text == "Guardar")
                {
                    Producto objproducto = new Producto();
                    objproducto.nombre = txtnombre.Text;
                    objproducto.marca = txtmarca.Text;
                    objproducto.precio = double.Parse(txtprecio.Text);

                    if (lN.insertarProducto(objproducto) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvproducto.DataSource = lN.ListarProductos();
                        txtmarca.Text = "";
                        txtnombre.Text = "";
                        txtprecio.Text = "";
                        tabControlproducto.SelectedTab = tpdetalle;
                    }
                    else { MessageBox.Show("Error al agregar producto"); }
                }
                if(btnguardarproducto.Text == "Actualizar")
                {
                    Producto objproducto = new Producto();
                    objproducto.id_producto = Convert.ToInt32(txtid.Text);
                    objproducto.nombre = txtnombre.Text;
                    objproducto.marca = txtmarca.Text;
                    objproducto.precio = double.Parse(txtprecio.Text);

                    if (lN.EditarProducto(objproducto) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dgvproducto.DataSource = lN.ListarProductos();
                        txtnombre.Text = "";
                        txtmarca.Text = "";
                        txtprecio.Text = "";
                        tabControlproducto.SelectedTab = tpdetalle;
                    }
                    else { MessageBox.Show("Error al actualizar producto"); }

                    btnguardarproducto.Text = "Guardar";
                }

            }
            catch 
            {
                MessageBox.Show("Errorrrrrrr");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id_producto = Convert.ToInt32(dgvproducto.CurrentRow.Cells["id_producto"].Value.ToString());

            try
            {
                if(lN.EliminarProducto(id_producto) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dgvproducto.DataSource = lN.ListarProductos();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar producto");
            }
        }

  
    }
}
