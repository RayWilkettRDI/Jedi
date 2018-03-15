using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class LinearMeasure
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
