using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdMatrixItemML")]
    public partial class NpdMatrixItemMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkMatrixItem", TypeName = "char(40)")]
        public string FkMatrixItem { get; set; }
        [StringLength(1024)]
        public string Guidance { get; set; }
    }
}
