using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class NutritionalOrigin
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("sequence")]
        public int Sequence { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("FCLID")]
        public int? Fclid { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
