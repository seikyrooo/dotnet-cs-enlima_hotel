//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace enlimahotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            this.tbl_reservasi = new HashSet<tbl_reservasi>();
        }
    
        public int user_id { get; set; }
        public byte[] photo { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<bool> active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_reservasi> tbl_reservasi { get; set; }
    }
}
