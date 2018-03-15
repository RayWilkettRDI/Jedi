using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class DrlAttachment
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        [Column(TypeName = "char(10)")]
        public string FileType { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
    }
}
