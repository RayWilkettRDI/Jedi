using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonWorkflowStatus")]
    public partial class CommonWorkflowStatus
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("status")]
        [StringLength(75)]
        public string Status { get; set; }
        [Column("instructions")]
        [StringLength(1000)]
        public string Instructions { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        
        //public IEnumerable<SpecSummary> SpecSummaries { get; set; }
    }
}
