using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("LinearWorkflowWorkItemDO")]
    public partial class LinearWorkflowWorkItemDo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkWorkItemType", TypeName = "char(40)")]
        public string FkWorkItemType { get; set; }
        [Column("fkDataObject", TypeName = "char(40)")]
        public string FkDataObject { get; set; }
        [Column("fkLinearWorkflowProcess", TypeName = "char(40)")]
        public string FkLinearWorkflowProcess { get; set; }
    }
}
