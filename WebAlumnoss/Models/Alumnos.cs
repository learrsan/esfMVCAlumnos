//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAlumnoss.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumnos
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public int idNacionalidad { get; set; }
    
        public virtual Nacionalidades Nacionalidades { get; set; }
    }
}
