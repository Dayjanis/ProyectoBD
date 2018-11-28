using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using FormJif;

namespace FormJif
{
    public partial class MDIJIF : Form
    {
        private int childFormNumber = 0;

        public MDIJIF()
        {
            InitializeComponent();
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    FCliente fc = new FCliente();
        //    fc.Show();
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Ventana " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    FProducto fp = new FProducto();
        //    fp.Show();
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = usuarioToolStripMenuItem.Checked;
        }

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = respaldoToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FCliente fc = new FCliente();
        //    fc.Show();
            
        //}
        //private void salirMenu_Click(object sender, EventArgs e)
        //{
        //    if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        Dispose(true);
        //        Application.Exit();
        //    }
        //}
        //private DialogResult PreClosingConfirmation()
        //{
        //    DialogResult res = System.Windows.Forms.MessageBox.Show("¿Esta seguro que quiere salir?","Cerrar la aplicacion",
        //                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    return res;

        //}


        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCredito FC = new FCredito();
            FC.Show();
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FCliente fc = new FCliente();
            fc.Show();

        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProducto fp = new FProducto();
            fp.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCred_Prod fcp = new FCred_Prod();
            fcp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("¿Esta seguro que quiere salir?","Cerrar la aplicacion",
                                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;

        }
        }
    }


