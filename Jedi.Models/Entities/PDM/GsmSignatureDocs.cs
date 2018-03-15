using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmSignatureDocs")]
    public partial class GsmSignatureDocs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkWorkflowStatus", TypeName = "char(40)")]
        public string FkWorkflowStatus { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public int? GroupSequence { get; set; }
        [Column("fkWorkflowProcessTemplate", TypeName = "char(40)")]
        public string FkWorkflowProcessTemplate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkflowStartDate { get; set; }
        [Column("fkFunctionalUnit", TypeName = "char(40)")]
        public string FkFunctionalUnit { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        [Column("fkParentWorkflowStatus", TypeName = "char(40)")]
        public string FkParentWorkflowStatus { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("ESignatureEnabled")]
        public bool? EsignatureEnabled { get; set; }
        public int? NumRequired { get; set; }
        public bool? IsNoActionEnabled { get; set; }
        public bool? IsCommentsRequired { get; set; }
    }
}
