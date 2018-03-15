using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdIdeaTemplateML")]
    public partial class NpdIdeaTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkIdeaTemplate", TypeName = "char(40)")]
        public string FkIdeaTemplate { get; set; }
        [Column("description")]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
