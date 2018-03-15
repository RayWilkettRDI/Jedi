using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("nsmNutrientCompositeML")]
    public partial class NsmNutrientCompositeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("description")]
        [StringLength(1024)]
        public string Description { get; set; }
        [Column("title")]
        [StringLength(250)]
        public string Title { get; set; }
        [Column("fkComposite", TypeName = "char(40)")]
        public string FkComposite { get; set; }
    }
}
