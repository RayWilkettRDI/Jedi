using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Cacs
{
    [Table("CACSApprovedUsageAttribute")]
    public partial class CacsapprovedUsageAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("GSMDataObjectType")]
        public int? GsmdataObjectType { get; set; }
        [StringLength(256)]
        public string DataSource { get; set; }
    }
}
