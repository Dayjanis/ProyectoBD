namespace formProducto
{
    partial class FormProducto
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
            this.tcproducto = new System.Windows.Forms.TabControl();
            this.tpregistrar = new System.Windows.Forms.TabPage();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnguardarpr = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.tpdetalle = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.tcproducto.SuspendLayout();
            this.tpregistrar.SuspendLayout();
            this.tpdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tcproducto
            // 
            this.tcproducto.Controls.Add(this.tpregistrar);
            this.tcproducto.Controls.Add(this.tpdetalle);
            this.tcproducto.Location = new System.Drawing.Point(12, 12);
            this.tcproducto.Name = "tcproducto";
            this.tcproducto.SelectedIndex = 0;
            this.tcproducto.Size = new System.Drawing.Size(653, 287);
            this.tcproducto.TabIndex = 0;
            // 
            // tpregistrar
            // 
            this.tpregistrar.Controls.Add(this.txtid);
            this.tpregistrar.Controls.Add(this.lblid);
            this.tpregistrar.Controls.Add(this.btnguardarpr);
            this.tpregistrar.Controls.Add(this.txtdescripcion);
            this.tpregistrar.Controls.Add(this.lbldescripcion);
            this.tpregistrar.Controls.Add(this.lblproducto);
            this.tpregistrar.Location = new System.Drawing.Point(4, 22);
            this.tpregistrar.Name = "tpregistrar";
            this.tpregistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpregistrar.Size = new System.Drawing.Size(645, 261);
            this.tpregistrar.TabIndex = 0;
            this.tpregistrar.Text = "Registrar";
            this.tpregistrar.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(112, 46);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 9;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(51, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "ID";
            // 
            // btnguardarpr
            // 
            this.btnguardarpr.Location = new System.Drawing.Point(112, 150);
            this.btnguardarpr.Name = "btnguardarpr";
            this.btnguardarpr.Size = new System.Drawing.Size(75, 23);
            this.btnguardarpr.TabIndex = 7;
            this.btnguardarpr.Text = "Guardar";
            this.btnguardarpr.UseVisualStyleBackColor = true;
            this.btnguardarpr.Click += new System.EventHandler(this.btnguardarpr_Click_1);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(112, 83);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 6;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(20, 91);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 5;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(93, 19);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(112, 13);
            this.lblproducto.TabIndex = 4;
            this.lblproducto.Text = "Registro de Productos";
            // 
            // tpdetalle
            // 
            this.tpdetalle.Controls.Add(this.btneliminar);
            this.tpdetalle.Controls.Add(this.btneditar);
            this.tpdetalle.Controls.Add(this.btnbuscar);
            this.tpdetalle.Controls.Add(this.txtbuscar);
            this.tpdetalle.Controls.Add(this.lblbuscar);
            this.tpdetalle.Controls.Add(this.dgvproducto);
            this.tpdetalle.Location = new System.Drawing.Point(4, 22);
            this.tpdetalle.Name = "tpdetalle";
            this.tpdetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpdetalle.Size = new System.Drawing.Size(645, 261);
            this.tpdetalle.TabIndex = 1;
            this.tpdetalle.Text = "Detalles";
            this.tpdetalle.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(467, 25);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(345, 26);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(240, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(98, 26);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(24, 26);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "Buscar";
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(24, 62);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(440, 179);
            this.dgvproducto.TabIndex = 0;
            //this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellContentClick);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 382);
            this.Controls.Add(this.tcproducto);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.tcproducto.ResumeLayout(false);
            this.tpregistrar.ResumeLayout(false);
            this.tpregistrar.PerformLayout();
            this.tpdetalle.ResumeLayout(false);
            this.tpdetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcproducto;
        private System.Windows.Forms.TabPage tpregistrar;
        private System.Windows.Forms.Button btnguardarpr;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.TabPage tpdetalle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btneliminar;

    }
}