namespace TotalGymWinFormApp
{
    partial class frmProductos
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
            this.gbproductos = new System.Windows.Forms.GroupBox();
            this.btnver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.ckno = new System.Windows.Forms.CheckBox();
            this.cksi = new System.Windows.Forms.CheckBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombrepro = new System.Windows.Forms.TextBox();
            this.txtcodigopro = new System.Windows.Forms.TextBox();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbproductos
            // 
            this.gbproductos.Controls.Add(this.btnRegresar);
            this.gbproductos.Controls.Add(this.btnver);
            this.gbproductos.Controls.Add(this.btnSalir);
            this.gbproductos.Controls.Add(this.btnagregar);
            this.gbproductos.Controls.Add(this.ckno);
            this.gbproductos.Controls.Add(this.cksi);
            this.gbproductos.Controls.Add(this.txtcantidad);
            this.gbproductos.Controls.Add(this.txtprecio);
            this.gbproductos.Controls.Add(this.txtdescripcion);
            this.gbproductos.Controls.Add(this.txtnombrepro);
            this.gbproductos.Controls.Add(this.txtcodigopro);
            this.gbproductos.Controls.Add(this.lblexistencia);
            this.gbproductos.Controls.Add(this.lblcantidad);
            this.gbproductos.Controls.Add(this.lblprecio);
            this.gbproductos.Controls.Add(this.lbldescripcion);
            this.gbproductos.Controls.Add(this.lblnombre);
            this.gbproductos.Controls.Add(this.lblcodigo);
            this.gbproductos.Location = new System.Drawing.Point(12, 12);
            this.gbproductos.Name = "gbproductos";
            this.gbproductos.Size = new System.Drawing.Size(652, 280);
            this.gbproductos.TabIndex = 0;
            this.gbproductos.TabStop = false;
            this.gbproductos.Text = "Productos";
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(532, 34);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(84, 39);
            this.btnver.TabIndex = 16;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(532, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 37);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(532, 170);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(84, 36);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // ckno
            // 
            this.ckno.AutoSize = true;
            this.ckno.Location = new System.Drawing.Point(223, 217);
            this.ckno.Name = "ckno";
            this.ckno.Size = new System.Drawing.Size(40, 17);
            this.ckno.TabIndex = 12;
            this.ckno.Text = "No";
            this.ckno.UseVisualStyleBackColor = true;
            // 
            // cksi
            // 
            this.cksi.AutoSize = true;
            this.cksi.Location = new System.Drawing.Point(118, 217);
            this.cksi.Name = "cksi";
            this.cksi.Size = new System.Drawing.Size(35, 17);
            this.cksi.TabIndex = 11;
            this.cksi.Text = "Si";
            this.cksi.UseVisualStyleBackColor = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(118, 179);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 10;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(118, 148);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(145, 20);
            this.txtprecio.TabIndex = 9;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(118, 115);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(176, 20);
            this.txtdescripcion.TabIndex = 8;
            // 
            // txtnombrepro
            // 
            this.txtnombrepro.Location = new System.Drawing.Point(118, 82);
            this.txtnombrepro.Name = "txtnombrepro";
            this.txtnombrepro.Size = new System.Drawing.Size(206, 20);
            this.txtnombrepro.TabIndex = 7;
            // 
            // txtcodigopro
            // 
            this.txtcodigopro.Location = new System.Drawing.Point(118, 50);
            this.txtcodigopro.Name = "txtcodigopro";
            this.txtcodigopro.Size = new System.Drawing.Size(155, 20);
            this.txtcodigopro.TabIndex = 6;
            this.txtcodigopro.TextChanged += new System.EventHandler(this.txtcodigopro_TextChanged);
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Location = new System.Drawing.Point(16, 217);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(55, 13);
            this.lblexistencia.TabIndex = 5;
            this.lblexistencia.Text = "Existencia";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(16, 186);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(16, 155);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "Precio";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(16, 122);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(16, 89);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(16, 57);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(86, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 201);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(532, 238);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(84, 36);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 511);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbproductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProductos_Load_1);
            this.gbproductos.ResumeLayout(false);
            this.gbproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbproductos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.CheckBox ckno;
        private System.Windows.Forms.CheckBox cksi;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombrepro;
        private System.Windows.Forms.TextBox txtcodigopro;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Button btnRegresar;
    }
}