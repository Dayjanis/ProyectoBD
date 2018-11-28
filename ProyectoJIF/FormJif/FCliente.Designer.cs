namespace FormJif
{
    partial class FCliente
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
            this.tabControlcliente = new System.Windows.Forms.TabControl();
            this.tpregistrar = new System.Windows.Forms.TabPage();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblregistro = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tpdetalle = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.tabControlcliente.SuspendLayout();
            this.tpregistrar.SuspendLayout();
            this.tpdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlcliente
            // 
            this.tabControlcliente.Controls.Add(this.tpregistrar);
            this.tabControlcliente.Controls.Add(this.tpdetalle);
            this.tabControlcliente.Location = new System.Drawing.Point(29, 27);
            this.tabControlcliente.Name = "tabControlcliente";
            this.tabControlcliente.SelectedIndex = 0;
            this.tabControlcliente.Size = new System.Drawing.Size(626, 274);
            this.tabControlcliente.TabIndex = 0;
            // 
            // tpregistrar
            // 
            this.tpregistrar.Controls.Add(this.lblid);
            this.tpregistrar.Controls.Add(this.txtid);
            this.tpregistrar.Controls.Add(this.txttelefono);
            this.tpregistrar.Controls.Add(this.txtapellido);
            this.tpregistrar.Controls.Add(this.txtnombre);
            this.tpregistrar.Controls.Add(this.lbltelefono);
            this.tpregistrar.Controls.Add(this.lblapellido);
            this.tpregistrar.Controls.Add(this.lblnombre);
            this.tpregistrar.Controls.Add(this.lblregistro);
            this.tpregistrar.Controls.Add(this.btnguardar);
            this.tpregistrar.Location = new System.Drawing.Point(4, 22);
            this.tpregistrar.Name = "tpregistrar";
            this.tpregistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpregistrar.Size = new System.Drawing.Size(618, 248);
            this.tpregistrar.TabIndex = 0;
            this.tpregistrar.Text = "Registrar";
            this.tpregistrar.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(39, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 17;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 16;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(117, 156);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 15;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(117, 128);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 14;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(117, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(22, 163);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 12;
            this.lbltelefono.Text = "Telefono";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(27, 135);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 11;
            this.lblapellido.Text = "Apellido";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(27, 97);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "Nombre";
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.Location = new System.Drawing.Point(78, 19);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(81, 13);
            this.lblregistro.TabIndex = 9;
            this.lblregistro.Text = "Registro Cliente";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(117, 211);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // tpdetalle
            // 
            this.tpdetalle.Controls.Add(this.btneliminar);
            this.tpdetalle.Controls.Add(this.btneditar);
            this.tpdetalle.Controls.Add(this.btnbuscar);
            this.tpdetalle.Controls.Add(this.lblbuscar);
            this.tpdetalle.Controls.Add(this.txtbuscar);
            this.tpdetalle.Controls.Add(this.dgvcliente);
            this.tpdetalle.Location = new System.Drawing.Point(4, 22);
            this.tpdetalle.Name = "tpdetalle";
            this.tpdetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpdetalle.Size = new System.Drawing.Size(618, 248);
            this.tpdetalle.TabIndex = 1;
            this.tpdetalle.Text = "Detalles";
            this.tpdetalle.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(468, 38);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(348, 39);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(250, 38);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(59, 44);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(120, 38);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(27, 74);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(364, 150);
            this.dgvcliente.TabIndex = 0;
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 361);
            this.Controls.Add(this.tabControlcliente);
            this.Name = "FCliente";
            this.Text = "FCliente";
            this.Load += new System.EventHandler(this.FCliente_Load);
            this.tabControlcliente.ResumeLayout(false);
            this.tpregistrar.ResumeLayout(false);
            this.tpregistrar.PerformLayout();
            this.tpdetalle.ResumeLayout(false);
            this.tpdetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlcliente;
        private System.Windows.Forms.TabPage tpregistrar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TabPage tpdetalle;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Button btneliminar;

    }
}