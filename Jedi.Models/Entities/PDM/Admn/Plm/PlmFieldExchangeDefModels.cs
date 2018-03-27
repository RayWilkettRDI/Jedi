using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmFieldExchangeDefModels")]
    public partial class PlmFieldExchangeDefModels
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("baseTag")]
        [StringLength(64)]
        public string BaseTag { get; set; }
        [Column("fkFieldExchangeCategory", TypeName = "char(40)")]
        public string FkFieldExchangeCategory { get; set; }
        [Column("isGlobal")]
        public bool? IsGlobal { get; set; }
        [Column("fkCommonCurrency", TypeName = "char(40)")]
        public string FkCommonCurrency { get; set; }
        [Column("fkDefaultCurrency", TypeName = "char(40)")]
        public string FkDefaultCurrency { get; set; }
        [Column("fkDefaultUOM", TypeName = "char(40)")]
        public string FkDefaultUom { get; set; }
        [Column("fkCommonUOM", TypeName = "char(40)")]
        public string FkCommonUom { get; set; }
        [Column("fkFieldExchangeUOMListDO", TypeName = "char(40)")]
        public string FkFieldExchangeUomlistDo { get; set; }
        [Column("dataType", TypeName = "char(4)")]
        public string DataType { get; set; }
        [Column("significantDecimalPlaces")]
        public int? SignificantDecimalPlaces { get; set; }
        [Column("fkCalcStrategy", TypeName = "char(40)")]
        public string FkCalcStrategy { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
    }
}
