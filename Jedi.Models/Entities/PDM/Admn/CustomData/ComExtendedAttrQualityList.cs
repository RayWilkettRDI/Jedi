using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("comExtendedAttrQualityList")]
    public partial class ComExtendedAttrQualityList
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(75)]
        public string ListName { get; set; }
        [Required]
        [Column("fkExtendedAttribute", TypeName = "char(40)")]
        public string FkExtendedAttribute { get; set; }
    }
}
