//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class LECTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LECTOR()
        {
            this.LECTOR_DETALLE = new HashSet<LECTOR_DETALLE>();
        }
    
        public string ID { get; set; }
        public string IDTDOCUMENTO { get; set; }
        public string SERIE { get; set; }
        public Nullable<int> NUMERO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string IDRESPONSABLE { get; set; }
        public Nullable<int> ESTADO { get; set; }

        public virtual RESPONSABLE RESPONSABLE { get; set; }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LECTOR_DETALLE> LECTOR_DETALLE { get; set; }
    }
}
