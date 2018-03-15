using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActivityTypeML")]
    public partial class NpdActivityTypeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActivityType", TypeName = "char(40)")]
        public string FkActivityType { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
