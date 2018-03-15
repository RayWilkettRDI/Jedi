using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonExtendedAttributeQuality")]
    public partial class CommonExtendedAttributeQuality
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkQualityList", TypeName = "char(40)")]
        public string FkQualityList { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("sortOrder")]
        public int? SortOrder { get; set; }
    }
}
