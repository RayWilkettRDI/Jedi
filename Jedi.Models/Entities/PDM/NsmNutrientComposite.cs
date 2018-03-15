using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("nsmNutrientComposite")]
    public partial class NsmNutrientComposite
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [StringLength(10)]
        public string CompositeNumber { get; set; }
        [Column("title")]
        [StringLength(250)]
        public string Title { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompositeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        [Column("fkContext", TypeName = "char(40)")]
        public string FkContext { get; set; }
    }
}
