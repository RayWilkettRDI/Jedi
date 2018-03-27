using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("NPDPackageCopyML")]
    public partial class NpdpackageCopyMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkPackageCopy", TypeName = "char(40)")]
        public string FkPackageCopy { get; set; }
        [StringLength(256)]
        public string BriefTitle { get; set; }
    }
}
