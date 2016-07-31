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
    class EQUIPO
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public EQUIPO()
            {
              try
              {
                  cn = new SqlConnection("Data Source=(local);Initial Catalog=TOTALGYM;Integrated Security=True");
                  cn.Open();
                  MessageBox.Show("conectado");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se establecio la conexion:" + ex.ToString());
              }
            }
        internal void conectar()
        {
            throw new NotImplementedException();
        }
        public string insertar(int COD_EQUIPO, int CANTIDAD, string NOM_EQUIPO)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Insert into EQUIPO(COD_EQUIPO,CANTIDAD,NOM_EQUIPO) values(" + COD_EQUIPO + "," + CANTIDAD + ",'" + NOM_EQUIPO + "')", cn);
                cmd.ExecuteNonQuery();
                return salida;
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                return salida;
            }

        }
        public int personaRegistrada(int COD_EQUIPO)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select*from EQUIPO where COD_EQUIPO=" + COD_EQUIPO + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public void cargarPersonas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from EQUIPO", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }
        public void llenarTexBoxConsulta(int COD_EQUIPO, string txtNombre, int txtCod, int txtCantidad)
        {
            try
            {
                cmd = new SqlCommand("Select * from EQUIPO where COD_EQUIPO=" + COD_EQUIPO + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre = dr["NOM_EQUIPO"].ToString();

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
