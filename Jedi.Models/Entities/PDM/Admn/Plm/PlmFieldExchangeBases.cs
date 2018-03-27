using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmFieldExchangeBases")]
    public partial class PlmFieldExchangeBases
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("description")]
        [StringLength(512)]
        public string Description { get; set; }
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }
        [Column("code")]
        [StringLength(32)]
        public string Code { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
