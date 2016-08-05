using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace TotalGymWinFormApp
{

    public partial class frmEquipo : Form
    {
        EQUIPO c = new EQUIPO();
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            c.conectar();
            mostrarDatos();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (c.eliminar("EQUIPO", "COD_EQUIPO =" + txtCod.Text))
            {
                MessageBox.Show("Se elimino correctamente");
                 txtCod.Text = "";
                 txtCantidad.Text = "";
                 txtNombre.Text = "";
                 mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");


            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuUsuario a = new frmMenuUsuario();
            a.Show();

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into EQUIPO values(" + txtCod.Text + "," + txtCantidad.Text + ",'" + txtNombre.Text + "')";
           if(c.agregar(agregar))
            {
                MessageBox.Show("se agrego correctamente");
                txtCod.Text = "";
                txtCantidad.Text = "";
                txtNombre.Text = "";
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("no se pudo agregar");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "COD_EQUIPO=" + txtCod.Text + ",CANTIDAD=" + txtCantidad.Text + ", NOM_EQUIPO='" + txtNombre.Text + "'";
            if (c.modificar("EQUIPO", actualizar, "COD_EQUIPO=" +txtCod.Text))
            {
                MessageBox.Show("Se modifico correctamente");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar");
            }

        }

        private void gbEquipo_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow datagrid = dgv.Rows[e.RowIndex];
            txtNombre.Text = datagrid.Cells[2].Value.ToString();
            txtCod.Text = datagrid.Cells[0].Value.ToString();
            txtCantidad.Text = datagrid.Cells[1].Value.ToString();

        }

        public void mostrarDatos()
        {
            c.consulta("select*from EQUIPO", "EQUIPO");
            dgv.DataSource = c.ds.Tables["EQUIPO"];

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
    }



}

