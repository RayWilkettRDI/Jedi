using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class DrlApplicationDrlReference
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(11)]
        public string OwningApplication { get; set; }
        [Column(TypeName = "char(40)")]
        public string OwnerId { get; set; }
        public bool? IsActive { get; set; }
    }
}
