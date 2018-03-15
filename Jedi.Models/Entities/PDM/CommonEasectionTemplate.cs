using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonEASectionTemplate")]
    public partial class CommonEasectionTemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(8)")]
        public string Num { get; set; }
        public int Status { get; set; }
        public bool IsAddedOnCreate { get; set; }
        [Column("lastEditDate", TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public double? DexVersion { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
        public bool? HideHeader { get; set; }
        [Column("ID")]
        [StringLength(24)]
        public string Id { get; set; }
        [Column("fkCategoryTab", TypeName = "char(40)")]
        public string FkCategoryTab { get; set; }
    }
}
