using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class CodeAgents
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }
        [Required]
        [Column("agentfactoryname")]
        [StringLength(250)]
        public string Agentfactoryname { get; set; }
        [Column("factoryargs")]
        [StringLength(250)]
        public string Factoryargs { get; set; }
        [Column("active")]
        public bool Active { get; set; }
    }
}
