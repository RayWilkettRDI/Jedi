using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdWorkflowProcessTemplates")]
    public partial class NpdWorkflowProcessTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("TemplateTypeID", TypeName = "char(40)")]
        public string TemplateTypeId { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
    }
}
