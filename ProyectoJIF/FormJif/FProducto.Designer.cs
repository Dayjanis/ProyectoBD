namespace FormJif
{
    partial class FProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlproducto = new System.Windows.Forms.TabControl();
            this.tpregistrar = new System.Windows.Forms.TabPage();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblregistroprod = new System.Windows.Forms.Label();
            this.btnguardarproducto = new System.Windows.Forms.Button();
            this.tpdetalle = new System.Windows.Forms.TabPage();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.tabControlproducto.SuspendLayout();
            this.tpregistrar.SuspendLayout();
            this.tpdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlproducto
            // 
            this.tabControlproducto.Controls.Add(this.tpregistrar);
            this.tabControlproducto.Controls.Add(this.tpdetalle);
            this.tabControlproducto.Location = new System.Drawing.Point(29, 27);
            this.tabControlproducto.Name = "tabControlproducto";
            this.tabControlproducto.SelectedIndex = 0;
            this.tabControlproducto.Size = new System.Drawing.Size(503, 328);
            this.tabControlproducto.TabIndex = 0;
            // 
            // tpregistrar
            // 
            this.tpregistrar.Controls.Add(this.lblid);
            this.tpregistrar.Controls.Add(this.txtid);
            this.tpregistrar.Controls.Add(this.txtprecio);
            this.tpregistrar.Controls.Add(this.txtmarca);
            this.tpregistrar.Controls.Add(this.txtnombre);
            this.tpregistrar.Controls.Add(this.lblprecio);
            this.tpregistrar.Controls.Add(this.lblmarca);
            this.tpregistrar.Controls.Add(this.lblnombre);
            this.tpregistrar.Controls.Add(this.lblregistroprod);
            this.tpregistrar.Controls.Add(this.btnguardarproducto);
            this.tpregistrar.Location = new System.Drawing.Point(4, 22);
            this.tpregistrar.Name = "tpregistrar";
            this.tpregistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpregistrar.Size = new System.Drawing.Size(495, 302);
            this.tpregistrar.TabIndex = 0;
            this.tpregistrar.Text = "Registrar";
            this.tpregistrar.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(32, 47);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 17;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(112, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 16;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(112, 176);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 15;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(112, 131);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 14;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 83);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(31, 179);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 12;
            this.lblprecio.Text = "Precio";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(31, 134);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 11;
            this.lblmarca.Text = "Marca";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(24, 86);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "Nombre";
            // 
            // lblregistroprod
            // 
            this.lblregistroprod.AutoSize = true;
            this.lblregistroprod.Location = new System.Drawing.Point(70, 21);
            this.lblregistroprod.Name = "lblregistroprod";
            this.lblregistroprod.Size = new System.Drawing.Size(92, 13);
            this.lblregistroprod.TabIndex = 9;
            this.lblregistroprod.Text = "Registro Producto";
            // 
            // btnguardarproducto
            // 
            this.btnguardarproducto.Location = new System.Drawing.Point(137, 244);
            this.btnguardarproducto.Name = "btnguardarproducto";
            this.btnguardarproducto.Size = new System.Drawing.Size(75, 23);
            this.btnguardarproducto.TabIndex = 8;
            this.btnguardarproducto.Text = "Guardar";
            this.btnguardarproducto.UseVisualStyleBackColor = true;
            this.btnguardarproducto.Click += new System.EventHandler(this.btnguardarproducto_Click_1);
            // 
            // tpdetalle
            // 
            this.tpdetalle.Controls.Add(this.btneditar);
            this.tpdetalle.Controls.Add(this.btneliminar);
            this.tpdetalle.Controls.Add(this.btnbuscar);
            this.tpdetalle.Controls.Add(this.lblbuscar);
            this.tpdetalle.Controls.Add(this.txtbuscar);
            this.tpdetalle.Controls.Add(this.dgvproducto);
            this.tpdetalle.Location = new System.Drawing.Point(4, 22);
            this.tpdetalle.Name = "tpdetalle";
            this.tpdetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpdetalle.Size = new System.Drawing.Size(495, 302);
            this.tpdetalle.TabIndex = 1;
            this.tpdetalle.Text = "Detalles";
            this.tpdetalle.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(300, 48);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(381, 46);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(210, 48);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(26, 56);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(85, 50);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(6, 93);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(437, 189);
            this.dgvproducto.TabIndex = 0;
            // 
            // FProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(661, 375);
            this.Controls.Add(this.tabControlproducto);
            this.Name = "FProducto";
            this.Text = "FProducto";
            this.Load += new System.EventHandler(this.FProducto_Load);
            this.tabControlproducto.ResumeLayout(false);
            this.tpregistrar.ResumeLayout(false);
            this.tpregistrar.PerformLayout();
            this.tpdetalle.ResumeLayout(false);
            this.tpdetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlproducto;
        private System.Windows.Forms.TabPage tpregistrar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblregistroprod;
        private System.Windows.Forms.Button btnguardarproducto;
        private System.Windows.Forms.TabPage tpdetalle;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvproducto;

    }
}