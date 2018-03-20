using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("comExtendedAttributeQualityML")]
    public partial class ComExtendedAttributeQualityMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkExtendedAttributeQuality", TypeName = "char(40)")]
        public string FkExtendedAttributeQuality { get; set; }
        [StringLength(250)]
        public string Quality { get; set; }
    }
}
