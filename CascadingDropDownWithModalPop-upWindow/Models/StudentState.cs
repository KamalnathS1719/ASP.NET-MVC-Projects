//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CascadingDropDown.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentState
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public Nullable<int> StudId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
