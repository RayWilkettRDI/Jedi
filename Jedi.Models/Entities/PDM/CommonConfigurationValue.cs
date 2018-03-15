using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonConfigurationValue")]
    public partial class CommonConfigurationValue
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(1000)]
        public string Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Required]
        [Column("fkConfigurationName", TypeName = "char(40)")]
        public string FkConfigurationName { get; set; }
        [Required]
        [Column("fkConfigurationBundle", TypeName = "char(40)")]
        public string FkConfigurationBundle { get; set; }
        public bool IsDefault { get; set; }
        public int Status { get; set; }
    }
}
