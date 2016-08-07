using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TotalGymWinFormApp
{
    public partial class frmCliente : Form
    {
       
        CLIENTE C = new CLIENTE();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

            C.conectar();
            mostrarDatos();

        }
        public void mostrarDatos()
        {
            C.consulta("select*from Clientes", "Clientes");
            dataGridView1.DataSource = C.ds.Tables["Clientes"];
            
        }
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into Clientes values(" + txtIdcliente.Text + ",'" + txtnombre.Text + "','" + txtapellido.Text + "'," + txtedad.Text + "," + txttelefono.Text + ",'" + txtdomicilio.Text + "','"+txtfecha_activo.Text+"','"+txtfecha_cad.Text+"')";
            if (C.agregar(agregar))
            {
                MessageBox.Show("Datos agregados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
                mostrarDatos();
            }


           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "ID_Cliente=" + txtIdcliente.Text + ",Nombre='" + txtnombre.Text + "',Apellido='" + txtapellido.Text + "',Edad=" + txtedad.Text + ",Telefono=" + txttelefono.Text + ",Domicilio='" + txtdomicilio.Text + "',fecha_activo='" + txtfecha_activo.Text + "',fecha_cad='" + txtfecha_cad.Text + "'";
            if (C.modificar("Clientes", actualizar, "ID_Cliente=" + txtIdcliente.Text))
            {
                MessageBox.Show("Datos Actualizados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al Actualizar");
            }
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (C.eliminar("Clientes", "ID_Cliente=" + txtIdcliente.Text))
            {
                MessageBox.Show("Se elimino");
                txtIdcliente.Text = "";
                txtnombre.Text = "";
                txtapellido.Text="";
                txtedad.Text = "";
                txttelefono.Text = "";
                txtdomicilio.Text = "";
                txtfecha_activo.Text = "";
                txtfecha_cad.Text = "";
                mostrarDatos();

            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
            
        }

        private void rbregistrar_CheckedChanged(object sender, EventArgs e)
        {
          




        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIdcliente_TextChanged(object sender, EventArgs e)
        {
           
            


            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow grid = dataGridView1.Rows[e.RowIndex];

            txtIdcliente.Text = grid.Cells[0].Value.ToString();
            txtnombre.Text = grid.Cells[1].Value.ToString();
            txtapellido.Text = grid.Cells[2].Value.ToString();
            txtedad.Text = grid.Cells[3].Value.ToString();
            txttelefono.Text = grid.Cells[4].Value.ToString();
            txtdomicilio.Text = grid.Cells[5].Value.ToString();
            txtfecha_activo.Text = grid.Cells[6].Value.ToString();
            txtfecha_cad.Text = grid.Cells[7].Value.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuUsuario a = new  frmMenuUsuario();
            a.Show();

            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }


