using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmTemperatureRange")]
    public partial class GsmTemperatureRange
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkConditionRequired", TypeName = "char(40)")]
        public string FkConditionRequired { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkMaximumTemperatureUom", TypeName = "char(40)")]
        public string FkMaximumTemperatureUom { get; set; }
        public double? MaximumTemperature { get; set; }
        [Column("fkLocale", TypeName = "char(40)")]
        public string FkLocale { get; set; }
        public double? MinimumTemperature { get; set; }
        [Column("fkMinimumTemperatureUom", TypeName = "char(40)")]
        public string FkMinimumTemperatureUom { get; set; }
    }
}
