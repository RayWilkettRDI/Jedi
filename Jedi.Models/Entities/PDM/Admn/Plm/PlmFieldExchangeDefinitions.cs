using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmFieldExchangeDefinitions")]
    public partial class PlmFieldExchangeDefinitions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFieldExchangeScope", TypeName = "char(40)")]
        public string FkFieldExchangeScope { get; set; }
        [StringLength(1024)]
        public string Calculation { get; set; }
        [Column("fkDefaultCurrency", TypeName = "char(40)")]
        public string FkDefaultCurrency { get; set; }
        [Column("fkFieldExchangeType", TypeName = "char(40)")]
        public string FkFieldExchangeType { get; set; }
        public int? SignificantDecimalPlaces { get; set; }
        [Column("fkCommonCurrency", TypeName = "char(40)")]
        public string FkCommonCurrency { get; set; }
        [StringLength(1024)]
        public string Tag { get; set; }
        [Column("fkCommonUOM", TypeName = "char(40)")]
        public string FkCommonUom { get; set; }
        [Column("fkFieldExchangeDirection", TypeName = "char(40)")]
        public string FkFieldExchangeDirection { get; set; }
        [Column("fkDefaultUOM", TypeName = "char(40)")]
        public string FkDefaultUom { get; set; }
        public int? CalculationSequence { get; set; }
        [Column("fkFieldExchangeCategory", TypeName = "char(40)")]
        public string FkFieldExchangeCategory { get; set; }
        [Column("isGlobal")]
        public bool? IsGlobal { get; set; }
        [Column("fkFieldExchangeUOMListDO", TypeName = "char(40)")]
        public string FkFieldExchangeUomlistDo { get; set; }
        [Column("dataType")]
        [StringLength(4)]
        public string DataType { get; set; }
        [Column("fkFieldExchangeBasis", TypeName = "char(40)")]
        public string FkFieldExchangeBasis { get; set; }
        [Column("fkFieldExchangePhase", TypeName = "char(40)")]
        public string FkFieldExchangePhase { get; set; }
        [Column("fkFieldExchangeFiscalYear", TypeName = "char(40)")]
        public string FkFieldExchangeFiscalYear { get; set; }
        [Column("fkFieldExchangeDefinitionModel", TypeName = "char(40)")]
        public string FkFieldExchangeDefinitionModel { get; set; }
        [Column("fkUOMCategory", TypeName = "char(40)")]
        public string FkUomcategory { get; set; }
        [Column("fkCalcStrategy", TypeName = "char(40)")]
        public string FkCalcStrategy { get; set; }
    }
}
