using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ORAttributeMetaInfo")]
    public partial class OrattributeMetaInfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("propertyname")]
        [StringLength(50)]
        public string Propertyname { get; set; }
        [Required]
        [Column("attributetablename")]
        [StringLength(30)]
        public string Attributetablename { get; set; }
        [Required]
        [Column("fkORClassMetaInfo", TypeName = "char(40)")]
        public string FkOrclassMetaInfo { get; set; }
        [Column("active")]
        public int Active { get; set; }
        public bool IsMultiByte { get; set; }
    }
}
