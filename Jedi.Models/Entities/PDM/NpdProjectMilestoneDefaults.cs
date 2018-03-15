using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdProjectMilestoneDefaults")]
    public partial class NpdProjectMilestoneDefaults
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProjectTemplate", TypeName = "char(40)")]
        public string FkProjectTemplate { get; set; }
    }
}
