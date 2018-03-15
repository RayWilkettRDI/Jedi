using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class RatingObservations
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
