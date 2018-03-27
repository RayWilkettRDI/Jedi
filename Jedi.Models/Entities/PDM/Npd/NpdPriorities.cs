using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdPriorities")]
    public partial class NpdPriorities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? DexVersion { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("langID")]
        public int? LangId { get; set; }
        public int? Status { get; set; }
    }
}
