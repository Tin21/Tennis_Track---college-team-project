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
    
    public partial class Mec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mec()
        {
            this.Sets = new HashSet<Set>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Prvi_clan_Id { get; set; }
        public Nullable<int> Drugi_clan_Id { get; set; }
        public Nullable<int> Teren_Id { get; set; }
        public int Turnir_Id { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
        public virtual Clan Clan { get; set; }
        public virtual Clan Clan1 { get; set; }
        public virtual Teren Teren { get; set; }
        public virtual Turnir Turnir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Set> Sets { get; set; }
    }
}