using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class MandatoryProperty
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(2)")]
        public string Operation { get; set; }
        [StringLength(128)]
        public string ValueHandler { get; set; }
        public bool? Hidden { get; set; }
        [Column("fkSearchableModel", TypeName = "char(40)")]
        public string FkSearchableModel { get; set; }
        [StringLength(64)]
        public string PropertyName { get; set; }
    }
}
