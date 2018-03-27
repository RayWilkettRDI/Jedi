using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonSupportingXDocuments")]
    public partial class CommonSupportingXdocuments
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkBusinessUnit", TypeName = "char(40)")]
        public string FkBusinessUnit { get; set; }
        [StringLength(256)]
        public string OriginalFilename { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
    }
}
