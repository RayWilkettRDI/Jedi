using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Ugm
{
    public partial class PermissionConditionObjects
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2000)]
        public string ObjectUrl { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
    }
}
