//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolveChicago.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class NonprofitMember
    {
        public int MemberId { get; set; }
        public int NonprofitId { get; set; }
        public Nullable<int> CaseManagerId { get; set; }
        public string MemberEnjoyed { get; set; }
        public string MemberStruggled { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Nonprofit Nonprofit { get; set; }
        public virtual CaseManager CaseManager { get; set; }
    }
}
