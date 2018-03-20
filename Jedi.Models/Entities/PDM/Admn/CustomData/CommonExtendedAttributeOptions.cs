using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("commonExtendedAttributeOptions")]
    public partial class CommonExtendedAttributeOptions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fieldNumber")]
        public int? FieldNumber { get; set; }
        [Column("sortOrder")]
        public int? SortOrder { get; set; }
        [Column("fieldId")]
        [StringLength(40)]
        public string FieldId { get; set; }
        [Column("attributeType")]
        [StringLength(40)]
        public string AttributeType { get; set; }
        [Column("isMultiSelect")]
        public bool? IsMultiSelect { get; set; }
    }
}
