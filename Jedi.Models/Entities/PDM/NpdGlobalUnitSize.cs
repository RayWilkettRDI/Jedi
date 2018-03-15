using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdGlobalUnitSize")]
    public partial class NpdGlobalUnitSize
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkMetricWeightUOM", TypeName = "char(40)")]
        public string FkMetricWeightUom { get; set; }
        [Column("fkMetricHeightUOM", TypeName = "char(40)")]
        public string FkMetricHeightUom { get; set; }
        public double? ImperialVolume { get; set; }
        public double? MetricWeight { get; set; }
        public double? MetricHeight { get; set; }
        [Column("fkMetricLengthUOM", TypeName = "char(40)")]
        public string FkMetricLengthUom { get; set; }
        public double? ImperialLength { get; set; }
        [Column("fkImperialHeightUOM", TypeName = "char(40)")]
        public string FkImperialHeightUom { get; set; }
        public double? ImperialHeight { get; set; }
        public double? ImperialWeight { get; set; }
        [Column("fkImperialVolumeUOM", TypeName = "char(40)")]
        public string FkImperialVolumeUom { get; set; }
        public double? MetricWidth { get; set; }
        [Column("fkImperialWeightUOM", TypeName = "char(40)")]
        public string FkImperialWeightUom { get; set; }
        [Column("fkImperialLengthUOM", TypeName = "char(40)")]
        public string FkImperialLengthUom { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkMetricVolumeUOM", TypeName = "char(40)")]
        public string FkMetricVolumeUom { get; set; }
        [Column("fkImperialWidthUOM", TypeName = "char(40)")]
        public string FkImperialWidthUom { get; set; }
        public double? MetricLength { get; set; }
        [Column("fkMetricWidthUOM", TypeName = "char(40)")]
        public string FkMetricWidthUom { get; set; }
        public double? MetricVolume { get; set; }
        public double? ImperialWidth { get; set; }
    }
}
