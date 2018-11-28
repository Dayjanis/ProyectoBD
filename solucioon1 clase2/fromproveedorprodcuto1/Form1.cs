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


namespace fromproveedorprodcuto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            logicaNegocioProveedors lN =new logicaNegocioProveedors();

            try
            {
                proeveedore objProveedor = new proeveedore();
                objProveedor.nombre = txtNombre.Text;
                objProveedor.direccion = txtDireccion.Text;
                objProveedor.telefono = txtTelefono.Text;

                if (lN.insertarProveedor(objProveedor) > 0)
                {
                    MessageBox.Show("Agregado con exito");
                    txtDireccion.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al agregar proveedor");
                }
            }
            catch { MessageBox.Show("errooorrrrrr"); }
        }
    }
}
