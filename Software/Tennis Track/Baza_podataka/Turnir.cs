//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tennis_Track.Baza_podataka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turnir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turnir()
        {
            this.Mecs = new HashSet<Mec>();
            this.Clans = new HashSet<Clan>();
        }
    
        public int Id { get; set; }
        public string Naziv { get; set; }
        public System.DateTime Datum { get; set; }
        public System.TimeSpan Vrijeme { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mec> Mecs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clan> Clans { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
