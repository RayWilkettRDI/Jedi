using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmProductIdentification")]
    public partial class GsmProductIdentification
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [StringLength(14)]
        public string GtinUpcNumber { get; set; }
        [StringLength(14)]
        public string VarGtinUpcNumber { get; set; }
    }
}
