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
    
    public partial class Profile_Info
    {
        public int Profile_Id { get; set; }
        public byte[] Profile_Photo { get; set; }
        public int Room_ID { get; set; }
        public int Leave_ID { get; set; }
    
        public virtual Allocation_Info Allocation_Info { get; set; }
        public virtual Leave_Info Leave_Info { get; set; }
        public virtual UserRegi UserRegi { get; set; }
    }
}