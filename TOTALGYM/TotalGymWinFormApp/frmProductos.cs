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

       
        public void mostrarDatos()
        {
            P.consulta("select*from PRODUCTOS", "PRODUCTOS");
            dataGridView1.DataSource = P.ds.Tables["PRODUCTOS"];
        }

        private void frmProductos_Load_1(object sender, EventArgs e)
        {
            P.conectar();
            mostrarDatos();


        }

       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into PRODUCTOS values(" + txtcodigopro.Text + ",'" + txtnombrepro.Text + "','" + txtdescripcion.Text + "'," + txtprecio.Text + "," + txtcantidad.Text + ",'"+txtsi_no.Text+"')";
            if (P.agregar(agregar))
            {
                MessageBox.Show("Datos agregados");
                mostrarDatos();

            }
            else
            {
                MessageBox.Show("Error al agregar");

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

     

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "COD_PRO=" + txtcodigopro.Text + ",NOMBRE_PRO='" + txtnombrepro.Text + "',DESCRIPCION='" + txtdescripcion.Text + "',PRECIO=" + txtprecio.Text + ",CANTIDAD=" + txtcantidad.Text + ",EXISTENCIA='"+txtsi_no.Text+"'";
            if (P.modificar("PRODUCTOS", actualizar, "COD_PRO=" + txtcodigopro.Text))
            {
                MessageBox.Show("Datos Actualizados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al Actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (P.eliminar("PRODUCTOS", "COD_PRO=" + txtcodigopro.Text))
            {
                MessageBox.Show("Se elimino");
                txtcodigopro.Text = "";
                txtnombrepro.Text = "";
                txtdescripcion.Text = "";
                txtprecio.Text = "";
                txtcantidad.Text = "";
                txtsi_no.Text = "";
              
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow grid = dataGridView1.Rows[e.RowIndex];

            
            txtcodigopro.Text = grid.Cells[0].Value.ToString();
            txtnombrepro.Text = grid.Cells[1].Value.ToString();
            txtdescripcion.Text = grid.Cells[2].Value.ToString();
            txtprecio.Text = grid.Cells[3].Value.ToString();
            txtcantidad.Text = grid.Cells[4].Value.ToString();
            txtsi_no.Text = grid.Cells[5].Value.ToString();
           

        }

        private void gbproductos_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuUsuario a = new frmMenuUsuario();
            a.Show();

            this.Close();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombrepro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
