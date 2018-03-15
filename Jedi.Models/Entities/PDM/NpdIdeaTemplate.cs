using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdIdeaTemplate")]
    public partial class NpdIdeaTemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkMetricCurrency", TypeName = "char(40)")]
        public string FkMetricCurrency { get; set; }
        [Column("isMarkedAsDeleted")]
        public bool? IsMarkedAsDeleted { get; set; }
        [Column("isPrivate")]
        public bool? IsPrivate { get; set; }
        [Column("isMasterTemplate")]
        public bool? IsMasterTemplate { get; set; }
        public bool? CanAddRemoveExtendedAttribute { get; set; }
        public bool? CanAddRemoveCustomSection { get; set; }
    }
}
