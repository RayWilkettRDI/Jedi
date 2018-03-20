using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("cssWorkflowProcessTemplates")]
    public partial class CssWorkflowProcessTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        public bool? Deleted { get; set; }
        public bool? Active { get; set; }
        [Column("fkPermissionTemplate", TypeName = "char(40)")]
        public string FkPermissionTemplate { get; set; }
        public bool? IsPrivate { get; set; }
        [Column("TemplateTypeID", TypeName = "char(40)")]
        public string TemplateTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        [Column(TypeName = "char(40)")]
        public string LastEditor { get; set; }
        [Column(TypeName = "char(40)")]
        public string Author { get; set; }
        public int? Revision { get; set; }
        public bool? SystemDefault { get; set; }
    }
}
