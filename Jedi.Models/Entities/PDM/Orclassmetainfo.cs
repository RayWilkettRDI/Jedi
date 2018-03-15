using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("orclassmetainfo")]
    public partial class Orclassmetainfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkORNamespaceMetaInfo", TypeName = "char(40)")]
        public string FkOrnamespaceMetaInfo { get; set; }
        [Required]
        [Column("tablename")]
        [StringLength(50)]
        public string Tablename { get; set; }
        [Required]
        [Column("classname")]
        [StringLength(50)]
        public string Classname { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("active")]
        public bool Active { get; set; }
        [Column("languageaware")]
        public bool Languageaware { get; set; }
        [Column("cacheable")]
        public bool Cacheable { get; set; }
        [Column("hasattributes")]
        public bool Hasattributes { get; set; }
        [Column("clonelangdata")]
        public bool Clonelangdata { get; set; }
        [Column("languageUIaware")]
        public bool LanguageUiaware { get; set; }
        [Column("implementedInterfaces")]
        [StringLength(2000)]
        public string ImplementedInterfaces { get; set; }
        public bool? MultiLanguageColumns { get; set; }
        [Column("abstract")]
        public bool? Abstract { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [StringLength(500)]
        public string KeyManager { get; set; }
    }
}
