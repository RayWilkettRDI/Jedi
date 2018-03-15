using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ObjectAssocationAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(200)]
        public string AttrName { get; set; }
        [StringLength(250)]
        public string AttrValue { get; set; }
        [Required]
        [Column("fkAttrParentID", TypeName = "char(40)")]
        public string FkAttrParentId { get; set; }
    }
}
