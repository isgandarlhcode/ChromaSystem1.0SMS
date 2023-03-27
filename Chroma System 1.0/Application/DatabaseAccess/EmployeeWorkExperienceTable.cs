//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeWorkExperienceTable
    {
        public int EmployeeWorkExperienceID { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FromYear { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ToYear { get; set; }
        public string Description { get; set; }
        public Nullable<int> EmployeeResumeID { get; set; }
        public int UserID { get; set; }

        public virtual EmployeeResumeTable EmployeeResumeTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
