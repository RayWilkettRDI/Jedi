using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqPackagingQuestionnaire")]
    public partial class EqPackagingQuestionnaire
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(500)]
        public string StorageInstructions { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(50)]
        public string SupplierPkgNumber { get; set; }
        [StringLength(100)]
        public string RelativeHumidity { get; set; }
        [StringLength(2400)]
        public string Comments { get; set; }
    }
}
