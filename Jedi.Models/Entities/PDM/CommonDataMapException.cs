using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonDataMapException")]
    public partial class CommonDataMapException
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkDataGroupMapping", TypeName = "char(40)")]
        public string FkDataGroupMapping { get; set; }
        [Column(TypeName = "char(40)")]
        public string ExceptionItem { get; set; }
    }
}
