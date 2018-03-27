using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonOwnedXDocument")]
    public partial class CommonOwnedXdocument
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string OriginalFilename { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fkSubmitter", TypeName = "char(40)")]
        public string FkSubmitter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateSubmitted { get; set; }
    }
}
