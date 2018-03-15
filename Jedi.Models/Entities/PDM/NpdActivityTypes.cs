using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActivityTypes")]
    public partial class NpdActivityTypes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("DataObjectTypeID")]
        public int? DataObjectTypeId { get; set; }
        [StringLength(256)]
        public string BusinessObjectType { get; set; }
        [StringLength(2000)]
        public string ConfigValues { get; set; }
        [Column("PBOLinkDescriptorSetID")]
        [StringLength(30)]
        public string PbolinkDescriptorSetId { get; set; }
    }
}
