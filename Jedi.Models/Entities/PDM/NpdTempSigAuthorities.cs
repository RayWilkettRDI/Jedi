using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdTempSigAuthorities")]
    public partial class NpdTempSigAuthorities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("fkCurrentOwner", TypeName = "char(40)")]
        public string FkCurrentOwner { get; set; }
        public bool? IsEnabled { get; set; }
        [Column("fkTempOwner", TypeName = "char(40)")]
        public string FkTempOwner { get; set; }
    }
}
