using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStrategicBriefTemplateML")]
    public partial class NpdStrategicBriefTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkProjectTemplate", TypeName = "char(40)")]
        public string FkProjectTemplate { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
    }
}
