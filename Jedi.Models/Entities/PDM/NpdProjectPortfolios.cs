using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdProjectPortfolios")]
    public partial class NpdProjectPortfolios
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(75)]
        public string Title { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        public bool? Deleted { get; set; }
        [Column("sequenceNumber")]
        public int? SequenceNumber { get; set; }
        [Column("description")]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
