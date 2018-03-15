using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSAvailableInML")]
    public partial class CacsavailableInMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAvailableIn", TypeName = "char(40)")]
        public string FkAvailableIn { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
