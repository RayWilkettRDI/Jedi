using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("commonExtendedAttributeType")]
    public partial class CommonExtendedAttributeType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("UOMCategory", TypeName = "char(2)")]
        public string Uomcategory { get; set; }
        [StringLength(200)]
        public string ListUrl { get; set; }
        public int? OptionStyle { get; set; }
        [Column("fkDefaultUOM", TypeName = "char(40)")]
        public string FkDefaultUom { get; set; }
        [Column(TypeName = "char(40)")]
        public string UsageCategory { get; set; }
        public int? RangeValues { get; set; }
        [StringLength(40)]
        public string AttributeType { get; set; }
        public bool? Active { get; set; }
        public int? Status { get; set; }
        [Column("LookupManagerID")]
        [StringLength(64)]
        public string LookupManagerId { get; set; }
        [StringLength(64)]
        public string LookupJavascriptPropertyAlias { get; set; }
        [Column("specDecPrecision")]
        public int? SpecDecPrecision { get; set; }
        public bool? UseSpecifiedPrecision { get; set; }
        [Column("multiSelectStyleOptions")]
        public int? MultiSelectStyleOptions { get; set; }
        public double? DexVersion { get; set; }
        [Column(TypeName = "ntext")]
        public string CalculationScript { get; set; }
        public bool? CalculationAllowsNulls { get; set; }
        [Column("AttributeID")]
        [StringLength(24)]
        public string AttributeId { get; set; }
        public bool? ShowCalculationErrors { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
        [Column("lookupJSPropertyAliasSearch")]
        [StringLength(64)]
        public string LookupJspropertyAliasSearch { get; set; }
        public int? RollupBehavior { get; set; }
        public int? DefaultState { get; set; }
        [StringLength(200)]
        public string DisplayText { get; set; }
        [Column("fkCategoryTab", TypeName = "char(40)")]
        public string FkCategoryTab { get; set; }
        [StringLength(30)]
        public string CalculationScriptEngine { get; set; }
    }
}
