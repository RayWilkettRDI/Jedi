using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFSectionControl")]
    public partial class ComLwfsectionControl
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkLinearWFUIConfiguration", TypeName = "char(40)")]
        public string FkLinearWfuiconfiguration { get; set; }
        [Column("ControlURL")]
        [StringLength(256)]
        public string ControlUrl { get; set; }
        [StringLength(80)]
        public string LabelId { get; set; }
    }
}
