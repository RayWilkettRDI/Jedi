using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specProcessPackagingAttribute")]
    public partial class SpecProcessPackagingAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkProcessSheet", TypeName = "char(40)")]
        public string FkProcessSheet { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        public double? MinNetWeight { get; set; }
        [Column("MinNetWeightUOM")]
        [StringLength(50)]
        public string MinNetWeightUom { get; set; }
        public double? MaxNetWeight { get; set; }
        [Column("MaxNetWeightUOM")]
        [StringLength(50)]
        public string MaxNetWeightUom { get; set; }
        public double? CaseContents { get; set; }
        public double? CaseGrossWeight { get; set; }
        [Column("CaseGrossWeightUOM")]
        [StringLength(50)]
        public string CaseGrossWeightUom { get; set; }
        public double? CasesPerPallet { get; set; }
        public double? CasesPerLayer { get; set; }
        public double? NumberLayers { get; set; }
        [Column(TypeName = "char(50)")]
        public string CaseType { get; set; }
        [Column(TypeName = "char(50)")]
        public string CaseGraphics { get; set; }
        public double? CaseLength { get; set; }
        public double? CaseWidth { get; set; }
        public double? CaseHeight { get; set; }
    }
}
