using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActTemplateAssociations")]
    public partial class NpdActTemplateAssociations
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? DependentProjectStageNumber { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public bool? Required { get; set; }
        [Column(TypeName = "char(40)")]
        public string DependentActivityStepPkid { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkParent2", TypeName = "char(40)")]
        public string FkParent2 { get; set; }
        public bool? HasParentWorkflowDependency { get; set; }
        [Column("DependentParentActivityStepPK", TypeName = "char(40)")]
        public string DependentParentActivityStepPk { get; set; }
    }
}
