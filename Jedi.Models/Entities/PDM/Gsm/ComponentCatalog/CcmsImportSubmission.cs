using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.ComponentCatalog
{
    [Table("ccmsImportSubmission")]
    public partial class CcmsImportSubmission
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkType", TypeName = "char(40)")]
        public string FkType { get; set; }
        public bool? UsesTemplate { get; set; }
        [StringLength(200)]
        public string ImportFilePath { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [StringLength(80)]
        public string Title { get; set; }
        [Column("fkSubmitter", TypeName = "char(40)")]
        public string FkSubmitter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmitDate { get; set; }
    }
}
