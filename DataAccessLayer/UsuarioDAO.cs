using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class UsuarioDAO
    {
        #region SINGLETON
        private static UsuarioDAO objUsuario = null;

        private UsuarioDAO() { }

        public static UsuarioDAO getInstance()
        {
            if (objUsuario == null) 
            {
                objUsuario = new UsuarioDAO();
            }
            return objUsuario;
        }
        #endregion

        public Usuario AccesoSistema(string nombre, string clave)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            Usuario objUsuario = null;
            SqlDataReader dr = null;

            try
            {
                connection = Connection.getInstance().ConnectionDB();
                cmd = new SqlCommand("spAccesoSistema", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@clave", clave);
                connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.Id = Convert.ToInt32(dr["Id"].ToString());
                    objUsuario.Nombre = dr["nombre"].ToString();
                    objUsuario.Clave = dr["clave"].ToString();
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return objUsuario;
        }
    }
}
