using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("commonLinearWorkflowStatuses")]
    public partial class CommonLinearWorkflowStatuses
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(1000)]
        public string Instructions { get; set; }
        [StringLength(256)]
        public string Caption { get; set; }
    }
}
