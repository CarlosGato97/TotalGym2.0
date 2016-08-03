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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            frmEQUIPOS U = new frmEQUIPOS();
            U.Show();
            this.Hide();
        }

        private void btnRutina_Click(object sender, EventArgs e)
        {
            frmRutina R = new frmRutina();
            R.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin a = new frmLogin();
            a.Show();

            this.Close();

        }
    }
}
