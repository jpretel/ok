using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class UsuarioDao
    {
        public List<USUARIO> GetUsuarios()
        {
            using(OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                return db.USUARIO.ToList();
            }
        }

        public void CrearUsuario (USUARIO usuario)
        {
            using(OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                db.USUARIO.Add(usuario);

                db.SaveChanges();
            }
        }

        public USUARIO GetIDusuario(String idusuario)
        {
            using(OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                USUARIO u;
                u = db.USUARIO.Where(c => c.IDUSUARIO == idusuario).FirstOrDefault();

                return u;
            }
        }

    }
}
