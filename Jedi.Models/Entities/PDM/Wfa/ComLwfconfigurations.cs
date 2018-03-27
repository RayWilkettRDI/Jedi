using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("comLWFConfigurations")]
    public partial class ComLwfconfigurations
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string ProcessManagerFactoryUrl { get; set; }
        [StringLength(256)]
        public string ProcessTemplateManagerFacUrl { get; set; }
        [StringLength(256)]
        public string TransitionTemplateMgrFacUrl { get; set; }
        [StringLength(256)]
        public string TransitionManagerFactoryUrl { get; set; }
        [StringLength(64)]
        public string WorkflowManagerId { get; set; }
        [StringLength(256)]
        public string ActivityTemplateManagerFacUrl { get; set; }
        [StringLength(256)]
        public string ActivityManagerFactoryUrl { get; set; }
        [StringLength(256)]
        public string ProcessTemplateResolverUrl { get; set; }
        [StringLength(256)]
        public string ActionTemplateMgrFactoryUrl { get; set; }
        [StringLength(256)]
        public string GuardConditionTemplMgrFacUrl { get; set; }
        [StringLength(256)]
        public string AttributeManagerFactoryUrl { get; set; }
        [Column("WFStatusManagerFactoryUrl")]
        [StringLength(256)]
        public string WfstatusManagerFactoryUrl { get; set; }
        [StringLength(256)]
        public string NotificationManagerFactoryUrl { get; set; }
        [StringLength(256)]
        public string NotifFunctionalAreaMgrFacUrl { get; set; }
        [StringLength(256)]
        public string ActivityOwnerManagerFactoryUrl { get; set; }
        [StringLength(256)]
        public string ResolutionSetManagerFactoryUrl { get; set; }
    }
}
