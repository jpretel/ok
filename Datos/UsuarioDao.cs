using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using System.Data.Entity;

namespace Datos
{
    public class UsuarioDao
    {
        Conexion cn = new Conexion();    
        public List<USUARIO> GetUsuarios()
        {
            List < USUARIO > l = Conexion.db.USUARIO.ToList();
            foreach (USUARIO u in l)
            {
                Conexion.db.Entry(u).State = EntityState.Detached;
            }
            return l;
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

            Conexion.db.Entry(u).State = EntityState.Detached;
            return u;           
        }


        public void ActualizaUsuario(USUARIO u)
        {
            Conexion.db.USUARIO.Attach(u);
            Conexion.db.Entry(u).State = EntityState.Modified;
            Conexion.db.SaveChanges();

            Conexion.db.Entry(u).State = EntityState.Detached;
        }

        public void BorrarUsuario(String idusuario)
        {
            Conexion.db.USUARIO.RemoveRange(Conexion.db.USUARIO.Where(x => x.IDUSUARIO == idusuario));
            Conexion.db.SaveChanges();
        }
    }
}
