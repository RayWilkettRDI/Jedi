using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdQuestionGroupTemplateML")]
    public partial class NpdQuestionGroupTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1024)]
        public string Title { get; set; }
        [Column("fkQuestionGroupTemplate", TypeName = "char(40)")]
        public string FkQuestionGroupTemplate { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
