using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdMatrixItems")]
    public partial class NpdMatrixItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAdditionalNotifyParent", TypeName = "char(40)")]
        public string FkAdditionalNotifyParent { get; set; }
        public bool? IsChangeAllowed { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkSigRequestParent", TypeName = "char(40)")]
        public string FkSigRequestParent { get; set; }
        [Column("fkFunctionalArea", TypeName = "char(40)")]
        public string FkFunctionalArea { get; set; }
        [Column("fkOwnerParent", TypeName = "char(40)")]
        public string FkOwnerParent { get; set; }
        [Column("fkSelectionMode", TypeName = "char(40)")]
        public string FkSelectionMode { get; set; }
        public bool? SetBasedOnProject { get; set; }
        public int? RequiredNumber { get; set; }
    }
}
