//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportAholics.Models
{
    using System;
    
    public partial class JoinEvent_Result
    {
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> StartDateTime { get; set; }
        public Nullable<System.TimeSpan> EndDateTime { get; set; }
        public string UserName { get; set; }
        public string SportName { get; set; }
        public Nullable<bool> IsJoin { get; set; }
        public string Event { get; set; }
        public int PlayerID { get; set; }
        public string Venue { get; set; }
    }
}
