//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VetpetEv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hora()
        {
            this.Detalle_consulta = new HashSet<Detalle_consulta>();
        }
    
        public int id_hora { get; set; }
        public System.DateTime fecha { get; set; }
        public string hora1 { get; set; }
        public int id_cliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_consulta> Detalle_consulta { get; set; }
    }
}