using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SupplierInitiatedQuestionaire
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? DueIn { get; set; }
        public int? AmberDateDueIn { get; set; }
        public int? CanSupplierInitiateEdits { get; set; }
        public int? DocumentationDueIn { get; set; }
        [Column("fkSAC", TypeName = "char(40)")]
        public string FkSac { get; set; }
        [Column("fkQuestionaireOwner", TypeName = "char(40)")]
        public string FkQuestionaireOwner { get; set; }
    }
}
