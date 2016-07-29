using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TotalGymWinFormApp
{
    class CLIENTE
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        internal object ds;


        public CLIENTE()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=TOTALGYM;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos" + ex.ToString());
            }
        }

        internal void Conectar()
        {
            throw new NotImplementedException();
        }

        public string inser(int ID_Cliente, string Nombre, string Apellido,int Edad, int Telefono, string Domicilio,string fecha_activo,string fecha_cad)
        {
            string salida = "Si se inserto";

            try
            {
                cmd = new SqlCommand("INSERT INTO Clientes(ID_Cliente,Nombre,Apellido,Edad,Telefono,Domicilio,fecha_activo,fecha_cad)values("+ID_Cliente+",'"+Nombre+"','"+Apellido+"',"+Edad+","+Telefono+",'"+Domicilio+"','"+fecha_activo+"','"+fecha_cad+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se conecto " + ex.ToString();
            }
            return salida;
        }

        internal string inser(object ID_Cliente, string nombre, string apellido, int edad, int telefono, string domicilio, string fecha_activo, string fecha_cad)
        {
            throw new NotImplementedException();
        }

        internal void consulta(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public int registradas(int ID_Cliente)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT*FROM Clientes WHERE ID_Cliente" + ID_Cliente + "", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar bien:" + ex.ToString());
            }
            return contador;
        }

        public void cargarPersonas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Clientes", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar:" + ex.ToString());
            }
        }

       

        public void llenarTextBoxConsulta(int ID_Cliente, string txtnombre, string txtapellido, string txtedad, string txttelefono, string txtdomicilio, string dateTimePicker1, string dateTimePicker2)
        {
            try
            {
                cmd = new SqlCommand("Select * from Clientes where ID_Cliente=" + ID_Cliente + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    txtnombre = dr["Nombre"].ToString();
                    txtapellido = dr["Apellido"].ToString();
                    txtedad = dr["Edad"].ToString();
                    txttelefono = dr["Telefono"].ToString();
                    txtdomicilio = dr["Domicilio"].ToString();
                    dateTimePicker1 = dr["fecha_activo"].ToString();
                    dateTimePicker2 = dr["fecha_cad"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
            public string modificar(int ID_Cliente,string Nombre, string Apellido,int Edad,int Telefono,string Domicilio,string fecha_activo,string fecha_cad)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("update Clientes set ID_Cliente=" + ID_Cliente + ",'" + Nombre + "','" + Apellido + "'," + Edad + "," + Telefono + ",'" + Domicilio + "','" + fecha_activo + "','" + fecha_cad + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
      
        }

        public bool eliminar( string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from" + tabla + "where" + condicion;
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
        }



    
}
