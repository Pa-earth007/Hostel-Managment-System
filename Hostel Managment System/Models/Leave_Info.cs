//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hostel_Managment_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leave_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leave_Info()
        {
            this.Profile_Info = new HashSet<Profile_Info>();
        }
    
        public int Leave_Id { get; set; }
        public string Destination { get; set; }
        public string Reason { get; set; }
        public System.DateTime Leave_Date { get; set; }
        public System.DateTime Arrival_Date { get; set; }
        public int Student_ID { get; set; }
        public int Room_ID { get; set; }
    
        public virtual Allocation_Info Allocation_Info { get; set; }
        public virtual UserRegi UserRegi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Profile_Info> Profile_Info { get; set; }
    }
}
