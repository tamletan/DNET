//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModelFirst.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Id { get; set; }
        public string Sname { get; set; }
        public System.DateTime Sbirth { get; set; }
        public int FId { get; set; }
        public double DTB { get; set; }
    
        public virtual Faculty Faculty { get; set; }
    }
}