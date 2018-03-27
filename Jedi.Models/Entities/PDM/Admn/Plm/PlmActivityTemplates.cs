using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmActivityTemplates")]
    public partial class PlmActivityTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActivityType", TypeName = "char(40)")]
        public string FkActivityType { get; set; }
        public bool? AllowFileAttachments { get; set; }
        public bool? IsCustomActivityTemplate { get; set; }
    }
}
