namespace TotalGymWinFormApp
{
    partial class frmMenuPrincipal
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
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.lblEtiquetaUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(8, 155);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(110, 13);
            this.lblInformacion.TabIndex = 13;
            this.lblInformacion.Text = "Acerca Total Gym 1.0";
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(71, 92);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(117, 28);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.Text = "Producto ";
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(71, 40);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(117, 28);
            this.btnEquipo.TabIndex = 9;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.UseVisualStyleBackColor = true;
            // 
            // lblNombreAdmin
            // 
            this.lblNombreAdmin.AutoSize = true;
            this.lblNombreAdmin.Location = new System.Drawing.Point(188, 15);
            this.lblNombreAdmin.Name = "lblNombreAdmin";
            this.lblNombreAdmin.Size = new System.Drawing.Size(0, 13);
            this.lblNombreAdmin.TabIndex = 8;
            // 
            // lblEtiquetaUsuario
            // 
            this.lblEtiquetaUsuario.AutoSize = true;
            this.lblEtiquetaUsuario.Location = new System.Drawing.Point(133, 15);
            this.lblEtiquetaUsuario.Name = "lblEtiquetaUsuario";
            this.lblEtiquetaUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblEtiquetaUsuario.TabIndex = 7;
            this.lblEtiquetaUsuario.Text = "Usuario: ";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 175);
            this.ControlBox = false;
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.lblNombreAdmin);
            this.Controls.Add(this.lblEtiquetaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Label lblNombreAdmin;
        private System.Windows.Forms.Label lblEtiquetaUsuario;
    }
}