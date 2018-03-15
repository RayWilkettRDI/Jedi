using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SearchableModelInfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(2)")]
        public string DefaultOperationCode { get; set; }
        [StringLength(64)]
        public string PrimaryKeyColumnName { get; set; }
        public bool? DefaultModel { get; set; }
        [Column("ModelClassTypeID")]
        [StringLength(64)]
        public string ModelClassTypeId { get; set; }
        [StringLength(64)]
        public string ModelName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        public int? CommandTimeout { get; set; }
        [StringLength(64)]
        public string DefaultCriteriaName { get; set; }
        [StringLength(64)]
        public string Alias { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        public int? CaptionColumn { get; set; }
        public bool? Customizable { get; set; }
        [StringLength(64)]
        public string DisplayName { get; set; }
        [StringLength(160)]
        public string OrderBy { get; set; }
    }
}
