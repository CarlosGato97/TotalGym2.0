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


namespace TotalGymWinFormApp
{
    public partial class frmLogin : Form

    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server= (local); Database=TOTALGYM; integrated security = true");
            conexion.Open();
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;
            string tipo;
            string pass2;

           string cadena=("select ID_Cliente,Contraseña, Tipo from TIPO where ID_Cliente="+user);
            SqlCommand comando = new SqlCommand(cadena,conexion);
            SqlDataReader read = comando.ExecuteReader();

            if (read.Read()) {
               pass2 = read["Contraseña"].ToString();
               tipo= read["tipo"].ToString();
                if (pass2==txtContraseña.Text){
                    if(tipo=="administrador"){
                        frmMenuAdmin add = new frmMenuAdmin();
                        add.Show();
                        this.Hide();
                    }
                    if (tipo=="Usuario") {
                        frmMenuAdmin add = new frmMenuAdmin();
                        add.Show();
                        this.Hide();
                    }
                    if (tipo=="cliente") {
                        frmMenuPrincipal prin = new frmMenuPrincipal();
                      prin.Show();
                        this.Hide();
                    }
                }
            }



        }
      
            
        }
    }
