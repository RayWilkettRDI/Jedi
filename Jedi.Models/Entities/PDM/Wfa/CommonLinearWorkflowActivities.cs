using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("commonLinearWorkflowActivities")]
    public partial class CommonLinearWorkflowActivities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? State { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        [Column("fkProcess", TypeName = "char(40)")]
        public string FkProcess { get; set; }
        public bool? OnHold { get; set; }
    }
}
