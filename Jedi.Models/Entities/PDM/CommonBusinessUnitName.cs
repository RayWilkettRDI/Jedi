using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonBusinessUnitName")]
    public partial class CommonBusinessUnitName
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
        [Column("name")]
        [StringLength(150)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(200)]
        public string Alias { get; set; }
    }
}
