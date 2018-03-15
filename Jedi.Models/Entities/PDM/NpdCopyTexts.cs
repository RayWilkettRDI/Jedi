using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdCopyTexts")]
    public partial class NpdCopyTexts
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? Approved { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column(TypeName = "ntext")]
        public string RichText { get; set; }
        [Column("fkType", TypeName = "char(40)")]
        public string FkType { get; set; }
    }
}
