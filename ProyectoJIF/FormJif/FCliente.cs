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
    public partial class FCliente : Form
    {
        public FCliente()
        {
            InitializeComponent();
        }
        logicaNegocioClienteF lN = new logicaNegocioClienteF();
        private void btnguardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                ClienteF objcliente = new ClienteF();
                objcliente.nombre = txtnombre.Text;
                objcliente.apellido = txtapellido.Text;
                objcliente.telefono = txttelefono.Text;

                if (lN.insertarClienteF(objcliente) > 0)
                {
                    MessageBox.Show("Agregado con exito!");
                    txtapellido.Text = "";
                    txttelefono.Text = "";
                    txtnombre.Text = "";
                }
                else { MessageBox.Show("Error al agregar cliente"); }
            }
            catch 
            {
                MessageBox.Show("Errorrrr");
            }
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            lblid.Visible = false;
            dgvcliente.DataSource = lN.ListarClientes();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            List<ClienteF> lista = lN.BuscaClienteDatos(txtbuscar.Text);
            dgvcliente.DataSource = lista;

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true; 

            txtnombre.Text = dgvcliente.CurrentRow.Cells["nombre"].Value.ToString();
            txtapellido.Text = dgvcliente.CurrentRow.Cells["apellido"].Value.ToString();
            txttelefono.Text = dgvcliente.CurrentRow.Cells["telefono"].Value.ToString();
            txtid.Text = dgvcliente.CurrentRow.Cells["idCliente"].Value.ToString();

            tabControlcliente.SelectedTab = tpregistrar;
            btnguardar.Text = "Actualizar";
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(btnguardar.Text == "Guardar")
                {
                    ClienteF objcliente = new ClienteF();
                    objcliente.nombre = txtnombre.Text;
                    objcliente.apellido = txtapellido.Text;
                    objcliente.telefono = txttelefono.Text;

                    if (lN.insertarClienteF(objcliente) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvcliente.DataSource = lN.ListarClientes();
                        txtapellido.Text = "";
                        txtnombre.Text = "";
                        txttelefono.Text = "";
                        tabControlcliente.SelectedTab = tpdetalle;
                    }
                    else { MessageBox.Show("Error al agregar cliente");}
                }
                if( btnguardar.Text == "Actualizar")
                {
                    ClienteF objcliente = new ClienteF();
                    objcliente.idCliente = Convert.ToInt32(txtid.Text);
                    objcliente.nombre = txtnombre.Text;
                    objcliente.apellido = txtapellido.Text;
                    objcliente.telefono = txttelefono.Text;

                    if (lN.EditarCliente(objcliente) > 0)
                    {
                        MessageBox.Show("Actualizado con exito!");
                        dgvcliente.DataSource = lN.ListarClientes();
                        txtapellido.Text = "";
                        txtnombre.Text = "";
                        txttelefono.Text = "";
                        tabControlcliente.SelectedTab = tpdetalle;
                    }
                    else { MessageBox.Show("Error al actulizar cliente"); }

                    btnguardar.Text = "Guardar";
                }
            }
            catch 
            {
                MessageBox.Show("Errorrrr");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(dgvcliente.CurrentRow.Cells["idCliente"].Value.ToString());

            try
            {
                if(lN.EliminarCliente(idCliente) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dgvcliente.DataSource = lN.ListarClientes();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
        }

    }
}
