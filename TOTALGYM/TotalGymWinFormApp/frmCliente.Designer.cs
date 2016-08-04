namespace TotalGymWinFormApp
{
    partial class frmCliente
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbregistrar = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtIdcliente = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.llbID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfecha_activo = new System.Windows.Forms.TextBox();
            this.txtfecha_cad = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gbCliente.Controls.Add(this.btnRegresar);
            this.gbCliente.Controls.Add(this.txtfecha_cad);
            this.gbCliente.Controls.Add(this.txtfecha_activo);
            this.gbCliente.Controls.Add(this.rbModificar);
            this.gbCliente.Controls.Add(this.rbEliminar);
            this.gbCliente.Controls.Add(this.rbregistrar);
            this.gbCliente.Controls.Add(this.btnEliminar);
            this.gbCliente.Controls.Add(this.btnSalir);
            this.gbCliente.Controls.Add(this.btnAgregar);
            this.gbCliente.Controls.Add(this.btnModificar);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.txtedad);
            this.gbCliente.Controls.Add(this.lbEdad);
            this.gbCliente.Controls.Add(this.txttelefono);
            this.gbCliente.Controls.Add(this.lbTelefono);
            this.gbCliente.Controls.Add(this.txtdomicilio);
            this.gbCliente.Controls.Add(this.lbDomicilio);
            this.gbCliente.Controls.Add(this.txtapellido);
            this.gbCliente.Controls.Add(this.txtnombre);
            this.gbCliente.Controls.Add(this.txtIdcliente);
            this.gbCliente.Controls.Add(this.lbApellido);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.lbNombre);
            this.gbCliente.Controls.Add(this.llbID);
            this.gbCliente.Location = new System.Drawing.Point(12, 23);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(392, 382);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            this.gbCliente.Enter += new System.EventHandler(this.gbCliente_Enter);
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(205, 32);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 24;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbModificar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(114, 32);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 23;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // rbregistrar
            // 
            this.rbregistrar.AutoSize = true;
            this.rbregistrar.Location = new System.Drawing.Point(13, 32);
            this.rbregistrar.Name = "rbregistrar";
            this.rbregistrar.Size = new System.Drawing.Size(67, 17);
            this.rbregistrar.TabIndex = 22;
            this.rbregistrar.TabStop = true;
            this.rbregistrar.Text = "Registrar";
            this.rbregistrar.UseVisualStyleBackColor = true;
            this.rbregistrar.CheckedChanged += new System.EventHandler(this.rbregistrar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(302, 61);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 30);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(302, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 30);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(302, 156);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 30);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(302, 110);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 30);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha _Cad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha_Activo";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(75, 248);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(50, 20);
            this.txtedad.TabIndex = 13;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(10, 255);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 12;
            this.lbEdad.Text = "Edad";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(75, 214);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 11;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(1, 221);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 10;
            this.lbTelefono.Text = "Telefono";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(75, 181);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(156, 20);
            this.txtdomicilio.TabIndex = 9;
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.Location = new System.Drawing.Point(6, 188);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lbDomicilio.TabIndex = 8;
            this.lbDomicilio.Text = "Domicilio";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(75, 149);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(124, 20);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(75, 116);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(124, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtIdcliente
            // 
            this.txtIdcliente.Location = new System.Drawing.Point(75, 87);
            this.txtIdcliente.Name = "txtIdcliente";
            this.txtIdcliente.Size = new System.Drawing.Size(82, 20);
            this.txtIdcliente.TabIndex = 4;
            this.txtIdcliente.TextChanged += new System.EventHandler(this.txtIdcliente_TextChanged);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(6, 156);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 123);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // llbID
            // 
            this.llbID.AutoSize = true;
            this.llbID.Location = new System.Drawing.Point(3, 90);
            this.llbID.Name = "llbID";
            this.llbID.Size = new System.Drawing.Size(52, 13);
            this.llbID.TabIndex = 0;
            this.llbID.Text = "ID cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 330);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtfecha_activo
            // 
            this.txtfecha_activo.Location = new System.Drawing.Point(80, 297);
            this.txtfecha_activo.Name = "txtfecha_activo";
            this.txtfecha_activo.Size = new System.Drawing.Size(151, 20);
            this.txtfecha_activo.TabIndex = 25;
            // 
            // txtfecha_cad
            // 
            this.txtfecha_cad.Location = new System.Drawing.Point(80, 327);
            this.txtfecha_cad.Name = "txtfecha_cad";
            this.txtfecha_cad.Size = new System.Drawing.Size(151, 20);
            this.txtfecha_cad.TabIndex = 26;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(302, 248);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(84, 35);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1003, 417);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label lbDomicilio;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtIdcliente;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label llbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbregistrar;
        private System.Windows.Forms.TextBox txtfecha_cad;
        private System.Windows.Forms.TextBox txtfecha_activo;
        private System.Windows.Forms.Button btnRegresar;
    }
}