using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFProcessTemplates")]
    public partial class ComLwfprocessTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? Deleted { get; set; }
        public bool? Active { get; set; }
        [Column(TypeName = "char(40)")]
        public string TemplateTypeId { get; set; }
        public int? Revision { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "char(40)")]
        public string Author { get; set; }
        [Column(TypeName = "char(40)")]
        public string LastEditor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        public bool? SystemDefault { get; set; }
    }
}
