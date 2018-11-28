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
    public partial class FCred_Prod : Form
    {
        public FCred_Prod()
        {
            InitializeComponent();
        }
        logicaNegocioCred_prod lN = new logicaNegocioCred_prod();
        Credito objcredito = new Credito();
        private void btnGuardarcp_Click(object sender, EventArgs e)
        {
           
            try
            {
                Cred_Prod objCred_prod = new Cred_Prod();
                objCred_prod.id_credito = Convert.ToInt32(txtidcred.Text);
                objCred_prod.id_producto = Convert.ToInt32(txtidprod.Text);

                if (lN.insertarCred_Prod(objCred_prod) > 0)
                {
                    MessageBox.Show("Agregado con exito!");
                    txtidcred.Text = "";
                    txtidprod.Text = "";
                }
                else { MessageBox.Show("Error al agregar credito_producto"); }
            }
            catch 
            {
                MessageBox.Show("Errorrrrrrr");
            }
        }

        private void FCred_Prod_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            lblid.Visible = false;
            dgvcred_prod.DataSource = lN.ListarCred_Prod();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            List<Cred_Prod> lista = lN.BuscaCred_prodDatos(txtbuscar.Text);
            dgvcred_prod.DataSource = lista;
                
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true;

            txtidcred.Text = dgvcred_prod.CurrentRow.Cells["id_credito"].Value.ToString();
            txtidprod.Text = dgvcred_prod.CurrentRow.Cells["id_producto"].Value.ToString();
            txtid.Text = dgvcred_prod.CurrentRow.Cells["id_cp"].Value.ToString();

            tabControlcred_prod.SelectedTab = tpregistrar;
            btnGuardarcp.Text = "Actualizar";
        }

        private void btnGuardarcp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardarcp.Text == "Guardar")
                {
                    Cred_Prod objcred_prod = new Cred_Prod();
                    objcred_prod.id_credito = Convert.ToInt32(txtidcred.Text);
                    objcred_prod.id_producto = Convert.ToInt32(txtidprod.Text);

                    if (lN.insertarCred_Prod(objcred_prod) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvcred_prod.DataSource = lN.ListarCred_Prod();
                        txtidcred.Text = "";
                        txtidprod.Text = "";
                        tabControlcred_prod.SelectedTab = tpdetalle;

                    }
                    else { MessageBox.Show("Error al agregar credito_producto"); }
                }
                if(btnGuardarcp.Text =="Actualizar")
                {
                    Cred_Prod objcred_prod = new Cred_Prod();
                    objcred_prod.id_cp = Convert.ToInt32(txtid.Text);
                    objcred_prod.id_credito = Convert.ToInt32(txtidcred.Text);
                    objcred_prod.id_producto = Convert.ToInt32(txtidprod.Text);

                    if (lN.EditarCred_prod(objcred_prod) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dgvcred_prod.DataSource = lN.ListarCred_Prod();
                        txtidcred.Text = "";
                        txtidprod.Text = "";
                        tabControlcred_prod.SelectedTab = tpdetalle;
                    }
                    else { MessageBox.Show("Error al actualizar credito_producto"); }

                    btnGuardarcp.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("Errorrrrrrr");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id_cp = Convert.ToInt32(dgvcred_prod.CurrentRow.Cells["id_cp"].Value.ToString());

            try
            {
                if(lN.EliminarCred_Prod(id_cp) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dgvcred_prod.DataSource = lN.ListarCred_Prod();
                }

            }
            catch
            {
                MessageBox.Show("Error al eliminar credito producto");
            }
        }


        }

    }

