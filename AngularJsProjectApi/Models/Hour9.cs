//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJsProjectApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hour9
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public long GroupId { get; set; }
        public long DayId { get; set; }
    
        public virtual Day Day { get; set; }
        public virtual GROUP GROUP { get; set; }
    }
}