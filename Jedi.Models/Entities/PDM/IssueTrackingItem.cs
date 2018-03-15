using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class IssueTrackingItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("priority")]
        public int Priority { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Required]
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Required]
        [Column("comments")]
        [StringLength(250)]
        public string Comments { get; set; }
        [Required]
        [Column("fkUserOwner", TypeName = "char(40)")]
        public string FkUserOwner { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [Column("category")]
        public int Category { get; set; }
    }
}
