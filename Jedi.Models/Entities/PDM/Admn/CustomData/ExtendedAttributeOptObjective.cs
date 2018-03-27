using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    public partial class ExtendedAttributeOptObjective
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? ObjectiveType { get; set; }
        public int? HandlingUnit { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        [Column("fkExtendedAttributeType", TypeName = "char(40)")]
        public string FkExtendedAttributeType { get; set; }
    }
}
