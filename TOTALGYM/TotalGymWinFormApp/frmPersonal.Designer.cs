namespace TotalGymWinFormApp
{
    partial class frmPersonal
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
            this.gppersonal = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblpuesto = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gppersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gppersonal
            // 
            this.gppersonal.BackColor = System.Drawing.Color.Cyan;
            this.gppersonal.BackgroundImage = global::TotalGymWinFormApp.Properties.Resources.ventanapersonal6;
            this.gppersonal.Controls.Add(this.btnModificar);
            this.gppersonal.Controls.Add(this.btnRegresar);
            this.gppersonal.Controls.Add(this.btnSalir);
            this.gppersonal.Controls.Add(this.btneliminar);
            this.gppersonal.Controls.Add(this.txtArea);
            this.gppersonal.Controls.Add(this.txtApellido);
            this.gppersonal.Controls.Add(this.txtNombre);
            this.gppersonal.Controls.Add(this.txtCodigo);
            this.gppersonal.Controls.Add(this.btnagregar);
            this.gppersonal.Controls.Add(this.lblapellido);
            this.gppersonal.Controls.Add(this.lblpuesto);
            this.gppersonal.Controls.Add(this.lblnombre);
            this.gppersonal.Controls.Add(this.lblcodigo);
            this.gppersonal.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gppersonal.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gppersonal.Location = new System.Drawing.Point(12, 12);
            this.gppersonal.Name = "gppersonal";
            this.gppersonal.Size = new System.Drawing.Size(467, 331);
            this.gppersonal.TabIndex = 0;
            this.gppersonal.TabStop = false;
            this.gppersonal.Text = "Personal";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DeepPink;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(370, 140);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(89, 37);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DeepPink;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(370, 83);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 37);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DeepPink;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(370, 213);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(89, 37);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(84, 180);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(182, 21);
            this.txtArea.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 140);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(252, 21);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 21);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 21);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.DeepPink;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(370, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(89, 37);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblapellido.Location = new System.Drawing.Point(21, 140);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(66, 16);
            this.lblapellido.TabIndex = 3;
            this.lblapellido.Text = "Apellido";
            // 
            // lblpuesto
            // 
            this.lblpuesto.AutoSize = true;
            this.lblpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblpuesto.Location = new System.Drawing.Point(21, 180);
            this.lblpuesto.Name = "lblpuesto";
            this.lblpuesto.Size = new System.Drawing.Size(56, 16);
            this.lblpuesto.TabIndex = 2;
            this.lblpuesto.Text = "Puesto";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblnombre.Location = new System.Drawing.Point(21, 102);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(63, 16);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblcodigo.Location = new System.Drawing.Point(21, 65);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(58, 16);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 349);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(467, 196);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DeepPink;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(370, 270);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 37);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(489, 557);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gppersonal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.gppersonal.ResumeLayout(false);
            this.gppersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gppersonal;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblpuesto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnModificar;
    }
}