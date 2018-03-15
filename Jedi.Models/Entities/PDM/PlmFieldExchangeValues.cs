using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmFieldExchangeValues")]
    public partial class PlmFieldExchangeValues
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? RawValue { get; set; }
        [Column("XDocPKID", TypeName = "char(40)")]
        public string XdocPkid { get; set; }
        [Column("FieldExchangeDefinitionPKID", TypeName = "char(40)")]
        public string FieldExchangeDefinitionPkid { get; set; }
        [Column("ProjectPKID", TypeName = "char(40)")]
        public string ProjectPkid { get; set; }
        [Column("ActivityPKID", TypeName = "char(40)")]
        public string ActivityPkid { get; set; }
        public double? ConvertedValue { get; set; }
        [Column("textValue")]
        [StringLength(1024)]
        public string TextValue { get; set; }
        [Column("dateValue", TypeName = "datetime")]
        public DateTime? DateValue { get; set; }
    }
}
