using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonMultiPartAttachment")]
    public partial class CommonMultiPartAttachment
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateSubmitted { get; set; }
        [Column("fkSubmitter", TypeName = "char(40)")]
        public string FkSubmitter { get; set; }
        [Column("fkEntity", TypeName = "char(40)")]
        public string FkEntity { get; set; }
    }
}
