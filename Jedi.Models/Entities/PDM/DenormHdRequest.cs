using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DENORM_HD_REQUEST")]
    public partial class DenormHdRequest
    {
        [Key]
        [Column("PKID", TypeName = "char(36)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public int Tag { get; set; }
        [StringLength(128)]
        public string Context { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastEdit { get; set; }
        [StringLength(512)]
        public string Remark { get; set; }
    }
}
