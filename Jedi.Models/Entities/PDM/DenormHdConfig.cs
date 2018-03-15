using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DENORM_HD_CONFIG")]
    public partial class DenormHdConfig
    {
        [Key]
        [Column(TypeName = "char(40)")]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Value { get; set; }
        [StringLength(512)]
        public string Remark { get; set; }
    }
}
