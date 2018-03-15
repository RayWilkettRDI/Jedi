using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("UOMCategoryML")]
    public partial class UomcategoryMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkUOMCategory", TypeName = "char(40)")]
        public string FkUomcategory { get; set; }
    }
}
