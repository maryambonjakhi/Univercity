//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Univercity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_teacher_record_employment
    {
        public int code_national_teacher { get; set; }
        public string name_place_work { get; set; }
        public string unit_organizational { get; set; }
        public string type_responsibility { get; set; }
        public Nullable<int> code_city { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}
