using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specPackagingPkgAttribute")]
    public partial class SpecPackagingPkgAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkPackagingID", TypeName = "char(40)")]
        public string FkPackagingId { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        [StringLength(50)]
        public string RelativeHumidity { get; set; }
        [StringLength(256)]
        public string StorageInstructions { get; set; }
        [Column("fkPackagingItemType", TypeName = "char(40)")]
        public string FkPackagingItemType { get; set; }
    }
}
