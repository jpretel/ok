using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using Datos;

namespace Negocio
{
    public class UsuarioCn
    {
        public static List<USUARIO> GetUsuarios()
        {
            UsuarioDao u = new UsuarioDao();
            return u.GetUsuarios();
        }

        public static void CrearUsuario(USUARIO usuario)
        {
            UsuarioDao u = new UsuarioDao();
            u.CrearUsuario(usuario);
        }

        public static USUARIO GetIDusuario(String idusuario)
        {
            UsuarioDao u = new UsuarioDao();
            return u.GetIDusuario(idusuario);
        }

        public static void CreaActualizaUsuario(USUARIO u)
        {
            UsuarioDao dao = new UsuarioDao();
            dao.BorrarUsuario(u.IDUSUARIO);

            dao.CrearUsuario(u);
        }

        public static void BorrarUsuario(String idusuario)
        {
            UsuarioDao dao = new UsuarioDao();
            dao.BorrarUsuario(idusuario);
        }
    }
}
