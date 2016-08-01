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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }
        PERSONAL con = new PERSONAL();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (con.eliminar("PERSONAL", "CODIGO=" + txtCodigo.Text))
            {
                MessageBox.Show("Se elimino");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow datagrid = dgv.Rows[e.RowIndex];
            txtNombre.Text = datagrid.Cells[0].Value.ToString();
            txtApellido.Text = datagrid.Cells[1].Value.ToString();
            txtArea.Text = datagrid.Cells[2].Value.ToString();
            txtCodigo.Text = datagrid.Cells[3].Value.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin a = new frmMenuAdmin();
            a.Show();

            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into PERSONAL values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtArea.Text + "'," + txtCodigo.Text + ")";
            if (con.agregar(agregar))
            {
                MessageBox.Show("Se agrego");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificar = "NOMBRE='" + txtNombre.Text + "',APELLIDO='" + txtApellido.Text + "',AREA='" + txtArea.Text + "',CODIGO=" + txtCodigo.Text +"";
            if (con.modificar("PERSONAL", modificar, "CODIGO=" + txtCodigo.Text))
            {
                MessageBox.Show("Datos modificados");
                    mostrarDatos();
            }
            else
            {
                MessageBox.Show("no se modifico");
            }
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            con.consulta("select*from PERSONAL", "PERSONAL");
            dgv.DataSource = con.ds.Tables["PERSONAL"];
        }

      
        }
    }