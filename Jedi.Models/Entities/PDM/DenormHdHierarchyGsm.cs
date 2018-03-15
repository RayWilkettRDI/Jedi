using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DENORM_HD_HIERARCHY_GSM")]
    public partial class DenormHdHierarchyGsm
    {
        [Key]
        [Column("PKID")]
        public int Pkid { get; set; }
        [Required]
        [Column("fkAncestor", TypeName = "char(40)")]
        public string FkAncestor { get; set; }
        [Required]
        [Column("fkDescendent", TypeName = "char(40)")]
        public string FkDescendent { get; set; }
        [Column("fkDescendentParent", TypeName = "char(40)")]
        public string FkDescendentParent { get; set; }
        public int CurrentLevel { get; set; }
        [Column("fkParentRelationshipContext")]
        public int FkParentRelationshipContext { get; set; }
        [Column("fkAncestorRelationshipContext")]
        public int FkAncestorRelationshipContext { get; set; }
        public int ObjectType { get; set; }
        [Column("fkObjectSubType", TypeName = "char(40)")]
        public string FkObjectSubType { get; set; }
        [Column("fkObjectSubTypeEx", TypeName = "char(40)")]
        public string FkObjectSubTypeEx { get; set; }
        [Column("fkRelationshipIdentifier", TypeName = "char(40)")]
        public string FkRelationshipIdentifier { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastEdit { get; set; }
        [StringLength(512)]
        public string Remark { get; set; }
        public int MaxLevel { get; set; }
        [Column(TypeName = "char(40)")]
        public string ContextOwner { get; set; }
        public int BoxLft { get; set; }
        public int BoxRgt { get; set; }
    }
}
