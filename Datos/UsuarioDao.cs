using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class UsuarioDao
    {
        Conexion cn = new Conexion();    
        public List<USUARIO> GetUsuarios()
        {                       
                return Conexion.db.USUARIO.ToList();            
        }

        public void CrearUsuario (USUARIO usuario)
        {
            Conexion.db.USUARIO.Add(usuario);
            Conexion.db.SaveChanges();            
        }

        public USUARIO GetIDusuario(String idusuario)
        {            
                USUARIO u;                
                u = Conexion.db.USUARIO.Where(c => c.IDUSUARIO == idusuario).FirstOrDefault();
                return u;           
        }

    }
}
