using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActDocumentCollaborations")]
    public partial class NpdActDocumentCollaborations
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("CurrentMultiPartAttachmentPKID", TypeName = "char(40)")]
        public string CurrentMultiPartAttachmentPkid { get; set; }
    }
}
