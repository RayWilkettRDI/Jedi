﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStageTemplateMilestoneML")]
    public partial class NpdStageTemplateMilestoneMl
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int? LangId { get; set; }
        [Column("comments")]
        [StringLength(256)]
        public string Comments { get; set; }
        [Required]
        [Column("fkStageTemplateMilestone", TypeName = "char(40)")]
        public string FkStageTemplateMilestone { get; set; }
    }
}
