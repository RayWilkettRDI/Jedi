using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmFunctionalAreas")]
    public partial class PlmFunctionalAreas
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
