using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ReportRequest
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "ntext")]
        public string GeneratedSql { get; set; }
        [Column("fkUserModel", TypeName = "char(40)")]
        public string FkUserModel { get; set; }
        [Column(TypeName = "char(40)")]
        public string FileReference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartProcessingDateTime { get; set; }
        [StringLength(256)]
        public string ModelName { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDateTime { get; set; }
        [Column("ModelViewURL")]
        [StringLength(256)]
        public string ModelViewUrl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinishedProcessingDateTime { get; set; }
        [StringLength(64)]
        public string ReportName { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
    }
}
