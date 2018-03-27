using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    public partial class CommonActivitySpecLink
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsReferencedOnSpec { get; set; }
        [Column("fkSpecification", TypeName = "char(40)")]
        public string FkSpecification { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
        public bool IsCustomAssociation { get; set; }
    }
}
