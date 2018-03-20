using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("commonEARowTemplate")]
    public partial class CommonEarowTemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int Sequence { get; set; }
        public int Status { get; set; }
        [Required]
        [Column("fkSectionTemplate", TypeName = "char(40)")]
        public string FkSectionTemplate { get; set; }
        public bool IsAddedOnCreate { get; set; }
        [Column("ID")]
        [StringLength(24)]
        public string Id { get; set; }
    }
}
