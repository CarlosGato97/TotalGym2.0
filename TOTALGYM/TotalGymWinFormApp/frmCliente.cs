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
    public partial class frmCliente : Form
    {
        CLIENTE C = new CLIENTE();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuAdmin administrador = new frmMenuAdmin();
            administrador.Show();
            this.Hide();

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CLIENTE C = new CLIENTE();
            C.cargarPersonas(dataGridView1);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (C.registradas(Convert.ToInt32(txtIdcliente.Text)) == 0)
            {
                int ID_Cliente = Convert.ToInt32(txtIdcliente.Text);
                string Nombre = txtnombre.Text;
                string Apellido = txtapellido.Text;
                int Edad = Convert.ToInt32(txtedad.Text);
                int Telefono = Convert.ToInt32(txttelefono.Text);
                string Domicilio = txtdomicilio.Text;
                string fecha_activo = dateTimePicker1.Text;
                string fecha_cad = dateTimePicker2.Text;

                MessageBox.Show(C.inser(ID_Cliente,Nombre,Apellido,Edad,Telefono,Domicilio,fecha_activo,fecha_cad));
                C.cargarPersonas(dataGridView1);

            }
            else
            {
                MessageBox.Show("Imposible de registrarse, el registro ya existe");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID_Cliente = Convert.ToInt32(txtIdcliente.Text);
            string Nombre = txtnombre.Text;
            string Apellido= txtapellido.Text;
            int Edad = Convert.ToInt32(txtedad.Text);
            int Telefono = Convert.ToInt32(txttelefono.Text);
            string Domicilio = txtdomicilio.Text;
            string fecha_activo = dateTimePicker1.Text;
            string fecha_cad = dateTimePicker2.Text;

            MessageBox.Show(C.inser(ID_Cliente, Nombre, Apellido, Edad, Telefono, Domicilio, fecha_activo, fecha_cad));
            C.cargarPersonas(dataGridView1);

        }
      

        }
    }

