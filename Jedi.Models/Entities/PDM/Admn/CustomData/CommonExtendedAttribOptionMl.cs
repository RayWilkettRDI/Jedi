using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("commonExtendedAttribOptionML")]
    public partial class CommonExtendedAttribOptionMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkExtendedAttributeOption", TypeName = "char(40)")]
        public string FkExtendedAttributeOption { get; set; }
    }
}
