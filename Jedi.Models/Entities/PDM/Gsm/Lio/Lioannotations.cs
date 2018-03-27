using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Lio
{
    [Table("LIOAnnotations")]
    public partial class Lioannotations
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2048)]
        public string Notes { get; set; }
        [Column("fkLIOElement", TypeName = "char(40)")]
        public string FkLioelement { get; set; }
    }
}
