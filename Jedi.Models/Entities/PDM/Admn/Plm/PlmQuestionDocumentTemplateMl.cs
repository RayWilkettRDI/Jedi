using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmQuestionDocumentTemplateML")]
    public partial class PlmQuestionDocumentTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkQuestionDocumentTemplate", TypeName = "char(40)")]
        public string FkQuestionDocumentTemplate { get; set; }
    }
}
