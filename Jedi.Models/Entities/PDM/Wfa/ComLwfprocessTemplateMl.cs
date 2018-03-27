using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("comLWFProcessTemplateML")]
    public partial class ComLwfprocessTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkLinearWFProcessTemplate", TypeName = "char(40)")]
        public string FkLinearWfprocessTemplate { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(512)]
        public string Description { get; set; }
    }
}
