using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbExtendedAttribute")]
    public partial class DwbExtendedAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOriginalValueExtAttribute", TypeName = "char(40)")]
        public string FkOriginalValueExtAttribute { get; set; }
        [Column("fkFinalValueExtendedAttribute", TypeName = "char(40)")]
        public string FkFinalValueExtendedAttribute { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public bool? IsOveridden { get; set; }
        public bool? IsTheoretical { get; set; }
        [StringLength(100)]
        public string TheoreticalMethod { get; set; }
    }
}
