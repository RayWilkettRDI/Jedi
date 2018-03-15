using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("SmartIssueRequestML")]
    public partial class SmartIssueRequestMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
    }
}
