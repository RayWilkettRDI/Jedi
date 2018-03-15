using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SmartIssueRequest
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column("fkInitiator", TypeName = "char(40)")]
        public string FkInitiator { get; set; }
        public bool? RevisionNutrients { get; set; }
        [Column(TypeName = "nchar(7)")]
        public string RequestNum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InitiationDate { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("sequenceNumber")]
        public int SequenceNumber { get; set; }
        [Column("fkSmartIssueType", TypeName = "char(40)")]
        public string FkSmartIssueType { get; set; }
        public bool? Private { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [StringLength(1024)]
        public string FailureReason { get; set; }
        public bool? SearchCriterion { get; set; }
    }
}
