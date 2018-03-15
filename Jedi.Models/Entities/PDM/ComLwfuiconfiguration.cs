using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFUIConfiguration")]
    public partial class ComLwfuiconfiguration
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ProcessTemplSummaryControlURL")]
        [StringLength(256)]
        public string ProcessTemplSummaryControlUrl { get; set; }
        [Column("FirstStepControlURL")]
        [StringLength(256)]
        public string FirstStepControlUrl { get; set; }
        [StringLength(256)]
        public string NotificationTokenDataSource { get; set; }
        [Column("ProcessInstanceViewControlURL")]
        [StringLength(256)]
        public string ProcessInstanceViewControlUrl { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("LastStepControlURL")]
        [StringLength(256)]
        public string LastStepControlUrl { get; set; }
        [Column("IntermediateStepControlURL")]
        [StringLength(256)]
        public string IntermediateStepControlUrl { get; set; }
        public bool? IsResolutionSetAware { get; set; }
    }
}
