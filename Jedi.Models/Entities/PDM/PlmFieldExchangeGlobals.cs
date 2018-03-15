using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmFieldExchangeGlobals")]
    public partial class PlmFieldExchangeGlobals
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? Value { get; set; }
        [Column("ParentPKID", TypeName = "char(40)")]
        public string ParentPkid { get; set; }
        [Column("fkOverrideUser", TypeName = "char(40)")]
        public string FkOverrideUser { get; set; }
        [Column("ProjectPKID", TypeName = "char(40)")]
        public string ProjectPkid { get; set; }
        public double? DerrivedValue { get; set; }
        [Column("FieldExchangeDefinitionPKID", TypeName = "char(40)")]
        public string FieldExchangeDefinitionPkid { get; set; }
        [StringLength(1024)]
        public string Tag { get; set; }
        [Column("ActivityPKID", TypeName = "char(40)")]
        public string ActivityPkid { get; set; }
        public double? OverrideValue { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsOverridden { get; set; }
        [Column("textValue")]
        [StringLength(1024)]
        public string TextValue { get; set; }
        [Column("dateValue", TypeName = "datetime")]
        public DateTime? DateValue { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkExplicitConversionTimeFrame", TypeName = "char(40)")]
        public string FkExplicitConversionTimeFrame { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
        [Column("valueSetDate", TypeName = "datetime")]
        public DateTime? ValueSetDate { get; set; }
        [Column("commonValue")]
        public double? CommonValue { get; set; }
        [StringLength(1024)]
        public string DerivedTextValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DerivedDateValue { get; set; }
    }
}
