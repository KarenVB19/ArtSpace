//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtSpace.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dirEntrega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dirEntrega()
        {
            this.Orden = new HashSet<Orden>();
        }
    
        public int id { get; set; }
        public string calle { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string telefono { get; set; }
        public int id_cliente { get; set; }
        public string codigo_postal { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden> Orden { get; set; }
    }
}