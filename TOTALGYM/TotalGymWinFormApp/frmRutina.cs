using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalGymWinFormApp
{
    public partial class frmRutina : Form
    {
        public frmRutina()
        {
            InitializeComponent();
        }

        RUTINA r = new RUTINA();
        private void btnodificar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRutina_Load(object sender, EventArgs e)
        {
            r.conectar();
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            r.consulta("select*from RUTINAS", "RUTINAS");
            dgv.DataSource = r.ds.Tables["RUTINAS"];

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal a = new frmMenuPrincipal();
            a.Show();
            

            this.Close();
        }
    }
}
