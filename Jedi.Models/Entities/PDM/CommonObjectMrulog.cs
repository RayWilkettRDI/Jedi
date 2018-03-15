using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonObjectMRULog")]
    public partial class CommonObjectMrulog
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        public bool? IsTemplate { get; set; }
        [Column("typeId")]
        [StringLength(10)]
        public string TypeId { get; set; }
        [Column("fkObjectID", TypeName = "char(40)")]
        public string FkObjectId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastAccessedDate { get; set; }
        public bool? IsCreationSource { get; set; }
        [Column("context")]
        public int? Context { get; set; }
        [Column("weight")]
        public int? Weight { get; set; }
        [StringLength(200)]
        public string LocationId { get; set; }
    }
}
