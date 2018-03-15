using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmFSISApplication")]
    public partial class GsmFsisapplication
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(8)]
        public string NumberOfDaysRequested { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        [Column("ESTNumber")]
        [StringLength(15)]
        public string Estnumber { get; set; }
        [StringLength(250)]
        public string Agent { get; set; }
        [Column(TypeName = "ntext")]
        public string Comments { get; set; }
        [Column(TypeName = "ntext")]
        public string ProcessingProcedures { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(15)]
        public string TotalAvailableSpace { get; set; }
        [StringLength(255)]
        public string Applicant { get; set; }
        [StringLength(8)]
        public string NumberOfLabelsOnHand { get; set; }
        [Column(TypeName = "ntext")]
        public string ProductFormula { get; set; }
        [StringLength(15)]
        public string PriorApprovalNumber { get; set; }
        public bool? PriorApproval { get; set; }
        [StringLength(8)]
        public string DateOfApproval { get; set; }
        [Column("HACCPCategory")]
        [StringLength(150)]
        public string Haccpcategory { get; set; }
        [StringLength(50)]
        public string ApprovalType { get; set; }
        [Column("fkParent")]
        [StringLength(40)]
        public string FkParent { get; set; }
        [Column("fkProcessSpec", TypeName = "char(40)")]
        public string FkProcessSpec { get; set; }
        [StringLength(15)]
        public string PrincipleDisplayArea { get; set; }
    }
}
