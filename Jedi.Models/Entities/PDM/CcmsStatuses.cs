using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ccmsStatuses")]
    public partial class CcmsStatuses
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStatusText", TypeName = "char(40)")]
        public string FkStatusText { get; set; }
        [Column("statusID")]
        [StringLength(50)]
        public string StatusId { get; set; }
    }
}
