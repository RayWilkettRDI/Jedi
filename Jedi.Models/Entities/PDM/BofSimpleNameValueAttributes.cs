using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("bofSimpleNameValueAttributes")]
    public partial class BofSimpleNameValueAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        [StringLength(512)]
        public string Value { get; set; }
    }
}
