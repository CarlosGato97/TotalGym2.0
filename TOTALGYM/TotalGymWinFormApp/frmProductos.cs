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
    public partial class frmProductos : Form
    {
        PRODUCTOS P = new PRODUCTOS();
        public frmProductos()
       {
            InitializeComponent();
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void lbldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load_1(object sender, EventArgs e)
        {

            PRODUCTOS p = new PRODUCTOS();
            p.cargarPersonas(dataGridView1);
        }

       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (P.personasregristradas(Convert.ToInt32(txtcodigopro.Text)) == 0)
            {
                int COD_PRO = Convert.ToInt32(txtcodigopro.Text);
                string NOMBRE_PRO = txtnombrepro.Text;
                string DESCRIPCION = txtdescripcion.Text;
                int PRECIO = Convert.ToInt32(txtprecio.Text);
                int CANTIDAD = Convert.ToInt32(txtcantidad.Text);
                string EXISTENCIA = cksi.Text;

                MessageBox.Show(P.insertar(COD_PRO, NOMBRE_PRO, DESCRIPCION, PRECIO, CANTIDAD, EXISTENCIA));
                P.cargarPersonas(dataGridView1);
            }
            else
            {
                MessageBox.Show("Imposible de registrarse, el registro ya existe");
            }


        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {


        }

        private void txtcodigopro_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin a = new frmMenuAdmin();
            a.Show();

            this.Close();
        }
    }
}
