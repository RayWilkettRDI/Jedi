using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmPackagingAttributeCoding")]
    public partial class GsmPackagingAttributeCoding
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkPackagingAttribute", TypeName = "char(40)")]
        public string FkPackagingAttribute { get; set; }
        [StringLength(1000)]
        public string CodingText { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
