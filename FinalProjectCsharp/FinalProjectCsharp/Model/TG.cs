//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProjectCsharp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TG
    {
        public int id { get; set; }
        public Nullable<int> Group_id { get; set; }
        public Nullable<int> Teacher_id { get; set; }
        public Nullable<int> Subject_id { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Subject Subject { get; set; }
    }
}