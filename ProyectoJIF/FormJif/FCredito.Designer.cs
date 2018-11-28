namespace FormJif
{
    partial class FCredito
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
            this.tabControlcredito = new System.Windows.Forms.TabControl();
            this.tpregistrar = new System.Windows.Forms.TabPage();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtfechacancel = new System.Windows.Forms.TextBox();
            this.txtfechainicio = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblmonto = new System.Windows.Forms.Label();
            this.lblfechacancel = new System.Windows.Forms.Label();
            this.lblfechainicio = new System.Windows.Forms.Label();
            this.lblregistrocredito = new System.Windows.Forms.Label();
            this.btnguardarcred = new System.Windows.Forms.Button();
            this.tpdetalle = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.dgvcredito = new System.Windows.Forms.DataGridView();
            this.tabControlcredito.SuspendLayout();
            this.tpregistrar.SuspendLayout();
            this.tpdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcredito)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlcredito
            // 
            this.tabControlcredito.Controls.Add(this.tpregistrar);
            this.tabControlcredito.Controls.Add(this.tpdetalle);
            this.tabControlcredito.Location = new System.Drawing.Point(12, 12);
            this.tabControlcredito.Name = "tabControlcredito";
            this.tabControlcredito.SelectedIndex = 0;
            this.tabControlcredito.Size = new System.Drawing.Size(838, 314);
            this.tabControlcredito.TabIndex = 0;
            // 
            // tpregistrar
            // 
            this.tpregistrar.Controls.Add(this.txtCliente);
            this.tpregistrar.Controls.Add(this.label1);
            this.tpregistrar.Controls.Add(this.lblid);
            this.tpregistrar.Controls.Add(this.txtid);
            this.tpregistrar.Controls.Add(this.txtestado);
            this.tpregistrar.Controls.Add(this.txtmonto);
            this.tpregistrar.Controls.Add(this.txtfechacancel);
            this.tpregistrar.Controls.Add(this.txtfechainicio);
            this.tpregistrar.Controls.Add(this.lblestado);
            this.tpregistrar.Controls.Add(this.lblmonto);
            this.tpregistrar.Controls.Add(this.lblfechacancel);
            this.tpregistrar.Controls.Add(this.lblfechainicio);
            this.tpregistrar.Controls.Add(this.lblregistrocredito);
            this.tpregistrar.Controls.Add(this.btnguardarcred);
            this.tpregistrar.Location = new System.Drawing.Point(4, 22);
            this.tpregistrar.Name = "tpregistrar";
            this.tpregistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpregistrar.Size = new System.Drawing.Size(830, 288);
            this.tpregistrar.TabIndex = 0;
            this.tpregistrar.Text = "Registrar";
            this.tpregistrar.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(163, 212);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(82, 54);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 21;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(163, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 20;
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(163, 173);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 20);
            this.txtestado.TabIndex = 19;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(163, 138);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 18;
            // 
            // txtfechacancel
            // 
            this.txtfechacancel.Location = new System.Drawing.Point(163, 106);
            this.txtfechacancel.Name = "txtfechacancel";
            this.txtfechacancel.Size = new System.Drawing.Size(100, 20);
            this.txtfechacancel.TabIndex = 17;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Location = new System.Drawing.Point(163, 80);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(100, 20);
            this.txtfechainicio.TabIndex = 16;
            this.txtfechainicio.TextChanged += new System.EventHandler(this.txtfechainicio_TextChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(48, 180);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 15;
            this.lblestado.Text = "Estado";
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(48, 145);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(64, 13);
            this.lblmonto.TabIndex = 14;
            this.lblmonto.Text = "Monto Total";
            // 
            // lblfechacancel
            // 
            this.lblfechacancel.AutoSize = true;
            this.lblfechacancel.Location = new System.Drawing.Point(48, 113);
            this.lblfechacancel.Name = "lblfechacancel";
            this.lblfechacancel.Size = new System.Drawing.Size(102, 13);
            this.lblfechacancel.TabIndex = 13;
            this.lblfechacancel.Text = "Fecha Cancelacion:";
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.AutoSize = true;
            this.lblfechainicio.Location = new System.Drawing.Point(48, 87);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(68, 13);
            this.lblfechainicio.TabIndex = 12;
            this.lblfechainicio.Text = "Fecha Inicio:";
            // 
            // lblregistrocredito
            // 
            this.lblregistrocredito.AutoSize = true;
            this.lblregistrocredito.Location = new System.Drawing.Point(116, 25);
            this.lblregistrocredito.Name = "lblregistrocredito";
            this.lblregistrocredito.Size = new System.Drawing.Size(82, 13);
            this.lblregistrocredito.TabIndex = 11;
            this.lblregistrocredito.Text = "Registro Credito";
            // 
            // btnguardarcred
            // 
            this.btnguardarcred.Location = new System.Drawing.Point(119, 250);
            this.btnguardarcred.Name = "btnguardarcred";
            this.btnguardarcred.Size = new System.Drawing.Size(75, 23);
            this.btnguardarcred.TabIndex = 10;
            this.btnguardarcred.Text = "Guardar";
            this.btnguardarcred.UseVisualStyleBackColor = true;
            this.btnguardarcred.Click += new System.EventHandler(this.btnguardarcred_Click_1);
            // 
            // tpdetalle
            // 
            this.tpdetalle.Controls.Add(this.btneliminar);
            this.tpdetalle.Controls.Add(this.btneditar);
            this.tpdetalle.Controls.Add(this.btnbuscar);
            this.tpdetalle.Controls.Add(this.txtbuscar);
            this.tpdetalle.Controls.Add(this.lblbuscar);
            this.tpdetalle.Controls.Add(this.dgvcredito);
            this.tpdetalle.Location = new System.Drawing.Point(4, 22);
            this.tpdetalle.Name = "tpdetalle";
            this.tpdetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpdetalle.Size = new System.Drawing.Size(830, 288);
            this.tpdetalle.TabIndex = 1;
            this.tpdetalle.Text = "Detalles";
            this.tpdetalle.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(467, 47);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(372, 46);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(277, 46);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(136, 57);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(54, 57);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "Buscar";
            // 
            // dgvcredito
            // 
            this.dgvcredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcredito.Location = new System.Drawing.Point(20, 107);
            this.dgvcredito.Name = "dgvcredito";
            this.dgvcredito.Size = new System.Drawing.Size(445, 150);
            this.dgvcredito.TabIndex = 0;
            // 
            // FCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 363);
            this.Controls.Add(this.tabControlcredito);
            this.Name = "FCredito";
            this.Text = "FCredito";
            this.Load += new System.EventHandler(this.FCredito_Load);
            this.tabControlcredito.ResumeLayout(false);
            this.tpregistrar.ResumeLayout(false);
            this.tpregistrar.PerformLayout();
            this.tpdetalle.ResumeLayout(false);
            this.tpdetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcredito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlcredito;
        private System.Windows.Forms.TabPage tpregistrar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtfechacancel;
        private System.Windows.Forms.TextBox txtfechainicio;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.Label lblfechacancel;
        private System.Windows.Forms.Label lblfechainicio;
        private System.Windows.Forms.Label lblregistrocredito;
        private System.Windows.Forms.Button btnguardarcred;
        private System.Windows.Forms.TabPage tpdetalle;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridView dgvcredito;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;

    }
}