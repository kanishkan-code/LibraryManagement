//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        public int id { get; set; }
        public string bname { get; set; }
        public Nullable<int> cat_id { get; set; }
        public Nullable<int> a_id { get; set; }
        public Nullable<int> p_id { get; set; }
        public string contents { get; set; }
        public Nullable<int> pages { get; set; }
        public string edition { get; set; }
    
        public virtual author author { get; set; }
        public virtual category category { get; set; }
        public virtual publisher publisher { get; set; }
    }
}
