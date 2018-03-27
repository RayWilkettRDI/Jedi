using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityTemplates")]
    public partial class NpdActivityTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? AllowFileAttachments { get; set; }
        public bool? IsPrivateCopy { get; set; }
        [Column("fkActivityType", TypeName = "char(40)")]
        public string FkActivityType { get; set; }
        [Column("fkMasterActivityTemplate", TypeName = "char(40)")]
        public string FkMasterActivityTemplate { get; set; }
        public bool? IsCustomActivityTemplate { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        public bool? PullSupportingDoc { get; set; }
        [Column("fkMetricCurrency", TypeName = "char(40)")]
        public string FkMetricCurrency { get; set; }
        public bool? CanAddRemoveCustomSection { get; set; }
        public bool? CanAddRemoveExtendedAttribute { get; set; }
    }
}
