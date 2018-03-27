using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("comLWFProcessTemplateTypes")]
    public partial class ComLwfprocessTemplateTypes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? CanBeConfigured { get; set; }
        [StringLength(256)]
        public string NotificationTokenDataSource { get; set; }
        [StringLength(256)]
        public string BusinessUnitTaxonomyNamespace { get; set; }
        [Column("fkWorkflowConfiguration", TypeName = "char(40)")]
        public string FkWorkflowConfiguration { get; set; }
        public bool? CanBeResolved { get; set; }
        public bool? CanHavePolicy { get; set; }
        public bool? CanBeSubProcess { get; set; }
        public bool? CanBeFirstClassWorkflow { get; set; }
        [Column("fkWorkflowUIConfiguration", TypeName = "char(40)")]
        public string FkWorkflowUiconfiguration { get; set; }
        [StringLength(256)]
        public string StatusDataSource { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
