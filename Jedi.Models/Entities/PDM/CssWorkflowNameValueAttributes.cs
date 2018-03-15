using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cssWorkflowNameValueAttributes")]
    public partial class CssWorkflowNameValueAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [StringLength(256)]
        public string Value { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
