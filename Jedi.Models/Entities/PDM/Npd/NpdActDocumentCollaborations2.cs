using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActDocumentCollaborations2")]
    public partial class NpdActDocumentCollaborations2
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("CurrentMultiPartAttachmentPKID", TypeName = "char(40)")]
        public string CurrentMultiPartAttachmentPkid { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
    }
}
