namespace FormJif
{
    partial class FCred_Prod
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
            this.tabControlcred_prod = new System.Windows.Forms.TabControl();
            this.tpregistrar = new System.Windows.Forms.TabPage();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtidcred = new System.Windows.Forms.TextBox();
            this.txtidprod = new System.Windows.Forms.TextBox();
            this.lblidcred = new System.Windows.Forms.Label();
            this.lblidprod = new System.Windows.Forms.Label();
            this.lblcred_prod = new System.Windows.Forms.Label();
            this.btnGuardarcp = new System.Windows.Forms.Button();
            this.tpdetalle = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvcred_prod = new System.Windows.Forms.DataGridView();
            this.tabControlcred_prod.SuspendLayout();
            this.tpregistrar.SuspendLayout();
            this.tpdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcred_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlcred_prod
            // 
            this.tabControlcred_prod.Controls.Add(this.tpregistrar);
            this.tabControlcred_prod.Controls.Add(this.tpdetalle);
            this.tabControlcred_prod.Location = new System.Drawing.Point(12, 24);
            this.tabControlcred_prod.Name = "tabControlcred_prod";
            this.tabControlcred_prod.SelectedIndex = 0;
            this.tabControlcred_prod.Size = new System.Drawing.Size(561, 277);
            this.tabControlcred_prod.TabIndex = 0;
            // 
            // tpregistrar
            // 
            this.tpregistrar.Controls.Add(this.txtid);
            this.tpregistrar.Controls.Add(this.lblid);
            this.tpregistrar.Controls.Add(this.txtidcred);
            this.tpregistrar.Controls.Add(this.txtidprod);
            this.tpregistrar.Controls.Add(this.lblidcred);
            this.tpregistrar.Controls.Add(this.lblidprod);
            this.tpregistrar.Controls.Add(this.lblcred_prod);
            this.tpregistrar.Controls.Add(this.btnGuardarcp);
            this.tpregistrar.Location = new System.Drawing.Point(4, 22);
            this.tpregistrar.Name = "tpregistrar";
            this.tpregistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpregistrar.Size = new System.Drawing.Size(553, 251);
            this.tpregistrar.TabIndex = 0;
            this.tpregistrar.Text = "Registrar";
            this.tpregistrar.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(128, 60);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 13;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(45, 60);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "ID";
            // 
            // txtidcred
            // 
            this.txtidcred.Location = new System.Drawing.Point(128, 125);
            this.txtidcred.Name = "txtidcred";
            this.txtidcred.Size = new System.Drawing.Size(100, 20);
            this.txtidcred.TabIndex = 11;
            // 
            // txtidprod
            // 
            this.txtidprod.Location = new System.Drawing.Point(128, 91);
            this.txtidprod.Name = "txtidprod";
            this.txtidprod.Size = new System.Drawing.Size(100, 20);
            this.txtidprod.TabIndex = 10;
            // 
            // lblidcred
            // 
            this.lblidcred.AutoSize = true;
            this.lblidcred.Location = new System.Drawing.Point(24, 128);
            this.lblidcred.Name = "lblidcred";
            this.lblidcred.Size = new System.Drawing.Size(57, 13);
            this.lblidcred.TabIndex = 9;
            this.lblidcred.Text = "ID_Credito";
            // 
            // lblidprod
            // 
            this.lblidprod.AutoSize = true;
            this.lblidprod.Location = new System.Drawing.Point(24, 94);
            this.lblidprod.Name = "lblidprod";
            this.lblidprod.Size = new System.Drawing.Size(67, 13);
            this.lblidprod.TabIndex = 8;
            this.lblidprod.Text = "ID_Producto";
            // 
            // lblcred_prod
            // 
            this.lblcred_prod.AutoSize = true;
            this.lblcred_prod.Location = new System.Drawing.Point(62, 26);
            this.lblcred_prod.Name = "lblcred_prod";
            this.lblcred_prod.Size = new System.Drawing.Size(131, 13);
            this.lblcred_prod.TabIndex = 7;
            this.lblcred_prod.Text = "Registro Credito_Producto";
            // 
            // btnGuardarcp
            // 
            this.btnGuardarcp.Location = new System.Drawing.Point(92, 177);
            this.btnGuardarcp.Name = "btnGuardarcp";
            this.btnGuardarcp.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarcp.TabIndex = 6;
            this.btnGuardarcp.Text = "Guardar";
            this.btnGuardarcp.UseVisualStyleBackColor = true;
            this.btnGuardarcp.Click += new System.EventHandler(this.btnGuardarcp_Click_1);
            // 
            // tpdetalle
            // 
            this.tpdetalle.Controls.Add(this.btneliminar);
            this.tpdetalle.Controls.Add(this.btneditar);
            this.tpdetalle.Controls.Add(this.btnbuscar);
            this.tpdetalle.Controls.Add(this.lblbuscar);
            this.tpdetalle.Controls.Add(this.txtbuscar);
            this.tpdetalle.Controls.Add(this.dgvcred_prod);
            this.tpdetalle.Location = new System.Drawing.Point(4, 22);
            this.tpdetalle.Name = "tpdetalle";
            this.tpdetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpdetalle.Size = new System.Drawing.Size(553, 251);
            this.tpdetalle.TabIndex = 1;
            this.tpdetalle.Text = "Detalles";
            this.tpdetalle.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(418, 47);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(337, 47);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(241, 51);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(60, 57);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(108, 51);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dgvcred_prod
            // 
            this.dgvcred_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcred_prod.Location = new System.Drawing.Point(30, 95);
            this.dgvcred_prod.Name = "dgvcred_prod";
            this.dgvcred_prod.Size = new System.Drawing.Size(427, 150);
            this.dgvcred_prod.TabIndex = 0;
            // 
            // FCred_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 347);
            this.Controls.Add(this.tabControlcred_prod);
            this.Name = "FCred_Prod";
            this.Text = "RegistroCredito_Prod";
            this.Load += new System.EventHandler(this.FCred_Prod_Load);
            this.tabControlcred_prod.ResumeLayout(false);
            this.tpregistrar.ResumeLayout(false);
            this.tpregistrar.PerformLayout();
            this.tpdetalle.ResumeLayout(false);
            this.tpdetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcred_prod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlcred_prod;
        private System.Windows.Forms.TabPage tpregistrar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtidcred;
        private System.Windows.Forms.TextBox txtidprod;
        private System.Windows.Forms.Label lblidcred;
        private System.Windows.Forms.Label lblidprod;
        private System.Windows.Forms.Label lblcred_prod;
        private System.Windows.Forms.Button btnGuardarcp;
        private System.Windows.Forms.TabPage tpdetalle;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvcred_prod;

    }
}