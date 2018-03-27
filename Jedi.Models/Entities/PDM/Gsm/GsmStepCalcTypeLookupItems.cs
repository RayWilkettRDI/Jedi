using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmStepCalcTypeLookupItems")]
    public partial class GsmStepCalcTypeLookupItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("StepCalcObjectLoaderURL")]
        [StringLength(550)]
        public string StepCalcObjectLoaderUrl { get; set; }
        public int? Status { get; set; }
        [StringLength(80)]
        public string StepCalcPath { get; set; }
        [StringLength(150)]
        public string StepCalcPathUserKey { get; set; }
    }
}
