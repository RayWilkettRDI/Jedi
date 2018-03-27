using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityTemplateStepML")]
    public partial class NpdActivityTemplateStepMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Status { get; set; }
        [StringLength(1024)]
        public string Instructions { get; set; }
        [Column("fkActivityTemplateStep", TypeName = "char(40)")]
        public string FkActivityTemplateStep { get; set; }
    }
}
