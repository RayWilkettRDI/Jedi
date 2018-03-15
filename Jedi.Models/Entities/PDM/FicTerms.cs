using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ficTerms")]
    public partial class FicTerms
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(7)")]
        public string TermNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastSavedDate { get; set; }
        [Column("fkLastSavedBy", TypeName = "char(40)")]
        public string FkLastSavedBy { get; set; }
        [Column("TermID")]
        [StringLength(50)]
        public string TermId { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
    }
}
