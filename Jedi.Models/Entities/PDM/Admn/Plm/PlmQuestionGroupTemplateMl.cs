﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmQuestionGroupTemplateML")]
    public partial class PlmQuestionGroupTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkQuestionGroupTemplate", TypeName = "char(40)")]
        public string FkQuestionGroupTemplate { get; set; }
        [StringLength(1024)]
        public string Title { get; set; }
    }
}
