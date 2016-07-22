namespace TotalGymWinFormApp
{
    partial class frmEquipo
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
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.gbEquipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEquipo
            // 
            this.gbEquipo.Controls.Add(this.lbCantidad);
            this.gbEquipo.Controls.Add(this.lbDescripcion);
            this.gbEquipo.Controls.Add(this.textBox4);
            this.gbEquipo.Controls.Add(this.textBox3);
            this.gbEquipo.Controls.Add(this.textBox2);
            this.gbEquipo.Controls.Add(this.lbNombre);
            this.gbEquipo.Controls.Add(this.btnConsultar);
            this.gbEquipo.Controls.Add(this.textBox1);
            this.gbEquipo.Controls.Add(this.lbCode);
            this.gbEquipo.Location = new System.Drawing.Point(12, 30);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(351, 237);
            this.gbEquipo.TabIndex = 0;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "Equipo";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(6, 159);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 8;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(6, 116);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 7;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(257, 33);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(6, 76);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(75, 13);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Codigo equipo";
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 279);
            this.ControlBox = false;
            this.Controls.Add(this.gbEquipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.frmEquipo_Load);
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCode;
    }
}