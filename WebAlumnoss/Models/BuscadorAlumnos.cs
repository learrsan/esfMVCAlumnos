using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;

namespace WebAlumnoss.Models
{
    public class BuscadorAlumnos
    {

        CursosEntities db=new CursosEntities();

        public List<Alumnos> GetPorApellidos(String apellidos)
        {
            var datos = from o in db.Alumnos
                where o.apellidos == apellidos
                select o;

            return datos.ToList();
        }

      
        public List<Alumnos> GetPorApellidosLambda(String apellidos)
        {

            var datos = db.Alumnos.Where(o => o.apellidos == apellidos && o.nombre=="Luis");
            return datos.ToList();
        }
    }
}