//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIT_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Answer()
        {
            this.AnswerTests = new HashSet<AnswerTest>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdTeam { get; set; }
        public Nullable<int> IdQuestion { get; set; }
        public string Answer1 { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public Nullable<int> Point { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Team Team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerTest> AnswerTests { get; set; }
    }
}
