using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmWorkflowGroupMapTaxonomy")]
    public partial class GsmWorkflowGroupMapTaxonomy
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        [Column("CustomID")]
        public int? CustomId { get; set; }
    }
}
