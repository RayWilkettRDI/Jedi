using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("regFSISApplicationType")]
    public partial class RegFsisapplicationType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(512)]
        public string Manager { get; set; }
        [Column("ID")]
        [StringLength(50)]
        public string Id { get; set; }
        [StringLength(256)]
        public string Control { get; set; }
        [Column("PrintFO")]
        [StringLength(256)]
        public string PrintFo { get; set; }
        public int? Status { get; set; }
    }
}
