using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("pqmSummary")]
    public partial class PqmSummary
    {
        [Key]
        [Column("pkid", TypeName = "char(10)")]
        public string Pkid { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column("fkWorkflowStatus", TypeName = "char(40)")]
        public string FkWorkflowStatus { get; set; }
        [Required]
        [Column("ItemID", TypeName = "char(10)")]
        public string ItemId { get; set; }
        public int? ItemType { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column("fkProcessTemplate", TypeName = "char(40)")]
        public string FkProcessTemplate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkflowStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditedDate { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? ActiveSigDocGroupSequence { get; set; }
        public int? ItemNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleasedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastWorkflowedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmittedDate { get; set; }
        public bool? IsTemplate { get; set; }
        [Column("fkOriginatingTemplate", TypeName = "char(40)")]
        public string FkOriginatingTemplate { get; set; }
        public int? SecurityAccessLevel { get; set; }
    }
}
