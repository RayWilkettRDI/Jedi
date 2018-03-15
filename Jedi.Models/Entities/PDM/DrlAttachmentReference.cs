using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class DrlAttachmentReference
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(40)")]
        public string DrlAttachmentId { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fileSize")]
        public int? FileSize { get; set; }
        [Column("title")]
        [StringLength(256)]
        public string Title { get; set; }
        [Column("fileName")]
        [StringLength(256)]
        public string FileName { get; set; }
    }
}
