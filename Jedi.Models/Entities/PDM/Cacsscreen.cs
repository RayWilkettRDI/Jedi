using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSScreen")]
    public partial class Cacsscreen
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(7)")]
        public string ScreenNumber { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
