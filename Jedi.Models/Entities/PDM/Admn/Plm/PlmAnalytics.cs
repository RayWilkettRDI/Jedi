using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmAnalytics")]
    public partial class PlmAnalytics
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("aggregationField")]
        [StringLength(64)]
        public string AggregationField { get; set; }
        [Column("isThreeDimensional")]
        public bool? IsThreeDimensional { get; set; }
        [Column("createDate", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
    }
}
