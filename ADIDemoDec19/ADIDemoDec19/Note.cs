//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADIDemoDec19
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        public int Id { get; set; }
        public Nullable<int> fbId { get; set; }
        public string Notes { get; set; }
        public Nullable<int> uId { get; set; }
    
        public virtual Feedback Feedback { get; set; }
        public virtual User User { get; set; }
    }
}
