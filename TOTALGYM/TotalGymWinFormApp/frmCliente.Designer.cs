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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCliente.Controls.Add(this.btnEliminar);
            this.gbCliente.Controls.Add(this.btnSalir);
            this.gbCliente.Controls.Add(this.btnAgregar);
            this.gbCliente.Controls.Add(this.btnModificar);
            this.gbCliente.Controls.Add(this.dateTimePicker2);
            this.gbCliente.Controls.Add(this.dateTimePicker1);
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
            this.gbCliente.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 33);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(338, 330);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            this.gbCliente.Enter += new System.EventHandler(this.gbCliente_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(241, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 30);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Teal;
            this.btnSalir.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(241, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 30);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(241, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 30);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(241, 87);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 30);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 294);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(9, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha _Cad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(10, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha_Activo";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(75, 215);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(50, 27);
            this.txtedad.TabIndex = 13;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.BackColor = System.Drawing.Color.Transparent;
            this.lbEdad.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(9, 215);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(37, 19);
            this.lbEdad.TabIndex = 12;
            this.lbEdad.Text = "Edad";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(75, 181);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 27);
            this.txttelefono.TabIndex = 11;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lbTelefono.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(6, 181);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(57, 19);
            this.lbTelefono.TabIndex = 10;
            this.lbTelefono.Text = "Telefono";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(75, 145);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(156, 27);
            this.txtdomicilio.TabIndex = 9;
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lbDomicilio.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDomicilio.Location = new System.Drawing.Point(6, 145);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(60, 19);
            this.lbDomicilio.TabIndex = 8;
            this.lbDomicilio.Text = "Domicilio";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(75, 110);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(124, 27);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(75, 73);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(124, 27);
            this.txtnombre.TabIndex = 5;
            // 
            // txtIdcliente
            // 
            this.txtIdcliente.Location = new System.Drawing.Point(75, 37);
            this.txtIdcliente.Name = "txtIdcliente";
            this.txtIdcliente.Size = new System.Drawing.Size(82, 27);
            this.txtIdcliente.TabIndex = 4;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.Transparent;
            this.lbApellido.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(6, 110);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(54, 19);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(6, 73);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(52, 19);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // llbID
            // 
            this.llbID.AutoSize = true;
            this.llbID.BackColor = System.Drawing.Color.Transparent;
            this.llbID.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.llbID.Location = new System.Drawing.Point(6, 40);
            this.llbID.Name = "llbID";
            this.llbID.Size = new System.Drawing.Size(63, 19);
            this.llbID.TabIndex = 0;
            this.llbID.Text = "ID cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(381, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 397);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbCliente);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
    }
}