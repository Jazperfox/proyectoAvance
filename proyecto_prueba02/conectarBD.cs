using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace proyecto_prueba02
{
    class conectarBD
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-D5LR6V6\SQLEXPRESS;Initial Catalog=dbprueba;Integrated Security=True");

        public int Login(string usuario, string pws)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pass", pws);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }

        public void insertarUsuario(string usuario, string nombre, int edad, int rango, string contra)
        {
            try
            {
                cnn.Open();
                SqlCommand commando = new SqlCommand("NuevoUsuario", cnn);
                commando.CommandType = CommandType.StoredProcedure;
                commando.Parameters.AddWithValue("@usuario", usuario);
                commando.Parameters.AddWithValue("@nombre", nombre);
                commando.Parameters.AddWithValue("@edad", edad);
                commando.Parameters.AddWithValue("@rango", rango);
                commando.Parameters.AddWithValue("@contra", contra);
                try
                {
                    commando.ExecuteNonQuery();
                    MessageBox.Show("usuario ingresado exitosamente");
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    cnn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        /// <summary>
        /// valida el rango del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Rango del usuario</returns>
        public string V_Rango(string usuario)
        {
            string U_rango;
            try
            {
                cnn.Open();
                SqlCommand commando = new SqlCommand("SP_Rango", cnn);
                commando.CommandType = CommandType.StoredProcedure;
                commando.Parameters.AddWithValue("@idUsuario", usuario);
                SqlDataReader rango = commando.ExecuteReader();
                if (rango.Read())
                {
                    return rango["Rango"].ToString();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }

            return "";

        }


    }
}
