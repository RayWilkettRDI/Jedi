using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityIMCFKCSSection7s")]
    public partial class NpdActivityImcfkcssection7s
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkMasterScheduled", TypeName = "char(40)")]
        public string FkMasterScheduled { get; set; }
        [StringLength(50)]
        public string OrderPolicy { get; set; }
        [StringLength(50)]
        public string ForcastWeightCode { get; set; }
        [Column("fkItemType", TypeName = "char(40)")]
        public string FkItemType { get; set; }
        [Column("fkItemClass", TypeName = "char(40)")]
        public string FkItemClass { get; set; }
        [StringLength(50)]
        public string HorizonDays { get; set; }
        [Column("fkActivityIMCF", TypeName = "char(40)")]
        public string FkActivityImcf { get; set; }
        [StringLength(50)]
        public string ShiftStdPerCase { get; set; }
        [StringLength(50)]
        public string PackSizeCode { get; set; }
        [StringLength(50)]
        public string ProducingPlants { get; set; }
        [Column("fkForcastedItem", TypeName = "char(40)")]
        public string FkForcastedItem { get; set; }
        [StringLength(50)]
        public string RptGrouping { get; set; }
        [StringLength(50)]
        public string LotSize { get; set; }
    }
}
