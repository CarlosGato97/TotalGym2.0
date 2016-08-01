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
    class PERSONAL
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=TOTALGYM;Integrated Security=True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommand comando;
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("conectado");
            }
            catch
            {
                MessageBox.Show("error al conectar");
            }
            finally
            {
                con.Close();
            }

        }
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

        }
        public bool agregar(string sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool eliminar(string tabla, string condicion)
        {
            con.Open();
            string eliminar = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(eliminar, con);
            int i = comando.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificar(string tabla, string campos, string condicion)
        {
            con.Open();
            string modificar = " update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(modificar, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
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


