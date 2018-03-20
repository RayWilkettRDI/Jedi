using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Compliance
{
    [Table("AdditiveContainedSourceML")]
    public partial class AdditiveContainedSourceMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [Column("fkAdditiveContained", TypeName = "char(40)")]
        public string FkAdditiveContained { get; set; }
    }
}
