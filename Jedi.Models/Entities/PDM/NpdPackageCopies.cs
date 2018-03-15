using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdPackageCopies")]
    public partial class NpdPackageCopies
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        [Column("fkCategory", TypeName = "char(40)")]
        public string FkCategory { get; set; }
        public int? CopyNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginationDate { get; set; }
        [Column("fkType", TypeName = "char(40)")]
        public string FkType { get; set; }
        [Column("LanguageID", TypeName = "char(40)")]
        public string LanguageId { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column(TypeName = "ntext")]
        public string RichText { get; set; }
    }
}
