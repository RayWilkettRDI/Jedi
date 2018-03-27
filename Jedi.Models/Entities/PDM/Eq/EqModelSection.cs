using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqModelSection")]
    public partial class EqModelSection
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(90)]
        public string Name { get; set; }
        [StringLength(90)]
        public string SectionKey { get; set; }
        public int? SequenceNumber { get; set; }
    }
}
