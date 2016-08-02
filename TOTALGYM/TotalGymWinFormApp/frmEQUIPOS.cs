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
    public partial class frmEQUIPOS : Form
    {
        EXISTENTES E = new EXISTENTES();
        public frmEQUIPOS()
        {
            InitializeComponent();
        }

        private void frmEQUIPOS_Load(object sender, EventArgs e)
        {
            E.conectar();
            mostrarDatos();

        }
        public void mostrarDatos()
        {
            E.consulta("select*from EQUIPO", "EQUIPO");
            dataGridView1.DataSource = E.ds.Tables["EQUIPO"];

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal U = new frmMenuPrincipal();
            U.Show();


            this.Close();
        }
    }
}
