//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblgorevler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblgorevler()
        {
            this.tblgorevdetaylar = new HashSet<tblgorevdetaylar>();
        }
    
        public int id { get; set; }
        public int gorevveren { get; set; }
        public int gorevalan { get; set; }
        public string aciklama { get; set; }
        public bool durum { get; set; }
        public System.DateTime tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblgorevdetaylar> tblgorevdetaylar { get; set; }
        public virtual tblpersonel tblpersonel { get; set; }
        public virtual tblpersonel tblpersonel1 { get; set; }
    }
}
