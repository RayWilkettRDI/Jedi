using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("orobjectpropertymetainfo")]
    public partial class Orobjectpropertymetainfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("mastercolumnname")]
        [StringLength(50)]
        public string Mastercolumnname { get; set; }
        [Required]
        [Column("propertyname")]
        [StringLength(50)]
        public string Propertyname { get; set; }
        [Column("backpointer")]
        public bool Backpointer { get; set; }
        [Required]
        [Column("slavepropertyname")]
        [StringLength(50)]
        public string Slavepropertyname { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("owned")]
        public bool Owned { get; set; }
        [Column("lazy")]
        public bool Lazy { get; set; }
        [Column("collection")]
        public bool Collection { get; set; }
        [Required]
        [Column("fkORClassMetaInfo", TypeName = "char(40)")]
        public string FkOrclassMetaInfo { get; set; }
        [Column("jointable", TypeName = "char(50)")]
        public string Jointable { get; set; }
        [Column("jointableslavecolumn", TypeName = "char(50)")]
        public string Jointableslavecolumn { get; set; }
        [Column("active")]
        public int Active { get; set; }
        [Column("readonly")]
        public bool Readonly { get; set; }
        [Column("collectionType")]
        public int CollectionType { get; set; }
        [Column("referencetype")]
        [StringLength(128)]
        public string Referencetype { get; set; }
        public bool? AutoCreate { get; set; }
        public bool? SupportsDynamicPolymorphism { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column("isCustomAssociationAllowed")]
        public bool IsCustomAssociationAllowed { get; set; }
    }
}
