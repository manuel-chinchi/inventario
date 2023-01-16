using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using EntitiesLayer;

namespace BusinessLayer
{
    public class UsuarioBL
    {
        #region SINGLETON
        private static UsuarioBL objUsuario = null;

        private UsuarioBL() { }

        public static UsuarioBL getInstance()
        {
            if (objUsuario == null)
            {
                objUsuario = new UsuarioBL();
            }
            return objUsuario;
        }
        #endregion

        public Usuario AccesoSistema(string nombre, string clave)
        {
            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(nombre, clave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
