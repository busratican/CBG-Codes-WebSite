//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace peeweeptech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategori
    {
        public Kategori()
        {
            this.Kod = new HashSet<Kod>();
        }
    
        public int kategori_id { get; set; }
        public string kategori_adi { get; set; }
    
        public virtual ICollection<Kod> Kod { get; set; }
    }
}
