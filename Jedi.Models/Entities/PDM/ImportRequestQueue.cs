using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ImportRequestQueue
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmittedDate { get; set; }
        [Column("fkSubmittedBy", TypeName = "char(40)")]
        public string FkSubmittedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDate { get; set; }
        public int? Status { get; set; }
        [StringLength(2048)]
        public string ImportLog { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        [StringLength(128)]
        public string TargetSystem { get; set; }
        public bool? IsActive { get; set; }
    }
}
