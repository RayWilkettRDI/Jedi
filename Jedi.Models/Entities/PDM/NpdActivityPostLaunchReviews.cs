using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActivityPostLaunchReviews")]
    public partial class NpdActivityPostLaunchReviews
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeaderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLaunchedInstore { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
    }
}
