using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmBrandInformationFreeText")]
    public partial class GsmBrandInformationFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string Brand { get; set; }
        [StringLength(128)]
        public string SubBrand { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(70)]
        public string ProductName { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        [Column("fkBrandInformation", TypeName = "char(40)")]
        public string FkBrandInformation { get; set; }
    }
}
