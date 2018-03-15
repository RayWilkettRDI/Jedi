using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActivities")]
    public partial class NpdActivities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        [Column("fkWorkflowProcess", TypeName = "char(40)")]
        public string FkWorkflowProcess { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModificationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkParent2", TypeName = "char(40)")]
        public string FkParent2 { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkModifier", TypeName = "char(40)")]
        public string FkModifier { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastWorkflowActionDate { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        [Column("fkProject", TypeName = "char(40)")]
        public string FkProject { get; set; }
        public bool? IsFieldExchangeActive { get; set; }
        [Column("fkDisplayCurrency", TypeName = "char(40)")]
        public string FkDisplayCurrency { get; set; }
        [Column("fkRootActivity", TypeName = "char(40)")]
        public string FkRootActivity { get; set; }
    }
}
