﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;

namespace TotalGymWinFormApp
{
    class EXISTENTES
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=TOTALGYM;Integrated Security=True");

        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommand comando;

        public void conectar()
        {
            try
            {
                cn.Open();
                MessageBox.Show("conectado");
            }
            catch
            {
                MessageBox.Show("Error al conectar");

            }
            finally
            {
                cn.Close();
            }
        }
        public bool modificar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string modificar = " update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(modificar, cn);
            int i = comando.ExecuteNonQuery();
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
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);


        }
    }
}
