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
    
    public partial class Profesores
    {
        public Profesores()
        {
            this.Profesores_Curso = new HashSet<Profesores_Curso>();
        }
    
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
    
        public virtual ICollection<Profesores_Curso> Profesores_Curso { get; set; }
    }
}