using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DWBSpecificationRoots")]
    public partial class DwbspecificationRoots
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecification", TypeName = "char(40)")]
        public string FkSpecification { get; set; }
        [Column("DWBNumber", TypeName = "char(7)")]
        public string Dwbnumber { get; set; }
        [Column("DWBIssueNumber", TypeName = "char(3)")]
        public string DwbissueNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ImportTimestamp { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column("fkGSMSaveTarget", TypeName = "char(40)")]
        public string FkGsmsaveTarget { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastSavedDate { get; set; }
        [Column("fkPrimaryOwner", TypeName = "char(40)")]
        public string FkPrimaryOwner { get; set; }
        public bool? IsPrivate { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
    }
}
