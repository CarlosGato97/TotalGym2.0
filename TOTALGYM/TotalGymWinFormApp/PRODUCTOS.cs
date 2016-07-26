using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TotalGymWinFormApp
{
    class PRODUCTOS
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        internal object ds;

        public PRODUCTOS()
        {
            try{
  
                cn= new SqlConnection( "Data Source=.;Initial Catalog=TOTALGYM;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos"+ex.ToString());

            }
        }

        internal void conectar()
        {
            throw new NotImplementedException();
        }
      
        public string insertar(int COD_PRO, string NOMBRE_PRO,string DESCRIPCION,int PRECIO,int CANTIDAD,string EXISTENCIA)
        {
            string salida = "Si se inserto";

            try
            {
                cmd = new SqlCommand("INSERT INTO PRODUCTOS(COD_PRO,NOMBRE_PRO,DESCRIPCION,PRECIO,CANTIDAD,EXISTENCIA)values (" + COD_PRO + ",'" + NOMBRE_PRO + "','" + DESCRIPCION + "'," + PRECIO + "," + CANTIDAD + ",'" + EXISTENCIA + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se conecto " + ex.ToString();
            }
            return salida;
        }
        internal void consulta(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public int personasregristradas(int COD_PRO)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT*FROM PRODUCTOS WHERE COD_PRO=" + COD_PRO + "", cn);
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
                da = new SqlDataAdapter("Select * from PRODUCTOS", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar:" + ex.ToString());
            }
        }

        public void llenarTextBoxConsulta(int COD_PRO,string txtnombrepro, string txtdescripcion,string txtprecio, string txtcantidad, bool cksi, bool ckno)
        {
            try
            {
                cmd = new SqlCommand("Select * from PRODUCTOS where COD_PRO=" + COD_PRO + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnombrepro = dr["Nombre"].ToString();
                    txtdescripcion = dr["Descripcion"].ToString();
                    txtprecio = dr["Precio"].ToString();
                    txtcantidad = dr["Cantidad"].ToString();
                    Convert.ToBoolean(cksi);
                    Convert.ToBoolean(ckno);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
    }
}
