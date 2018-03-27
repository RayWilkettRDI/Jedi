using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("dwbLIOGroups")]
    public partial class DwbLiogroups
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? PctUsed { get; set; }
        [Column(TypeName = "char(2)")]
        public string DisplayMethod { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(64)]
        public string ListName { get; set; }
    }
}
