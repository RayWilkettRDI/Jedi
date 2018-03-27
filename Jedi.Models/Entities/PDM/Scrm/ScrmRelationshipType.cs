using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmRelationshipType")]
    public partial class ScrmRelationshipType
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string ChildRelationship { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string ParentRelationship { get; set; }
    }
}
