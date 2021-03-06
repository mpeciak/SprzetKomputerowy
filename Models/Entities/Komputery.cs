//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SprzetKomputerowy.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komputery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Komputery()
        {
            this.Urzadzenia = new HashSet<Urzadzenia>();
            this.Zestawy = new HashSet<Zestawy>();
            this.Zestawy1 = new HashSet<Zestawy>();
        }
    
        public int IdKomputera { get; set; }
        public string Nazwakomputera { get; set; }
        public string Producent { get; set; }
        public Nullable<int> IdKlasyfikacjiKomputera { get; set; }
        public string NrSeryjny { get; set; }
        public Nullable<System.DateTime> DataProdukcji { get; set; }
        public Nullable<int> IdOsoby { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
        public Nullable<int> IdUrzadzeniaWeWy { get; set; }
        public string Status { get; set; }
        public string NrEwidencyjny { get; set; }
        public Nullable<int> IdLokalizacji { get; set; }
    
        public virtual KlasyfikacjaKomputera KlasyfikacjaKomputera { get; set; }
        public virtual Lokalizacja Lokalizacja { get; set; }
        public virtual Osoby Osoby { get; set; }
        public virtual UrzadzeniaWeWy UrzadzeniaWeWy { get; set; }
        public virtual UrzadzeniaWeWy UrzadzeniaWeWy1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urzadzenia> Urzadzenia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zestawy> Zestawy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zestawy> Zestawy1 { get; set; }
    }
}
