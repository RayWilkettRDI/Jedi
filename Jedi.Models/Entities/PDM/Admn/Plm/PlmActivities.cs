using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmActivities")]
    public partial class PlmActivities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        [Column("fkWorkflowProcess", TypeName = "char(40)")]
        public string FkWorkflowProcess { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkModifier", TypeName = "char(40)")]
        public string FkModifier { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModificationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastWorkflowActionDate { get; set; }
        [Column("fkParent2", TypeName = "char(40)")]
        public string FkParent2 { get; set; }
        public bool? IsFieldExchangeActive { get; set; }
    }
}
