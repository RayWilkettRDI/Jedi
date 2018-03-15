using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ccmsWorksetItemRejectComments")]
    public partial class CcmsWorksetItemRejectComments
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("rejectionComments")]
        [StringLength(500)]
        public string RejectionComments { get; set; }
        [Column("fkWorksetItem", TypeName = "char(40)")]
        public string FkWorksetItem { get; set; }
    }
}
