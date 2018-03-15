using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmCUPackagingFreeText")]
    public partial class GsmCupackagingFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkPackagingAttribute", TypeName = "char(40)")]
        public string FkPackagingAttribute { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
