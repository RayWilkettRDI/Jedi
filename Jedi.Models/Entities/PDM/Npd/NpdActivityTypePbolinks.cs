using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityTypePBOLinks")]
    public partial class NpdActivityTypePbolinks
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? GroupIndex { get; set; }
        public int? GroupNumber { get; set; }
        [Column("fkPBOLinkDescriptor", TypeName = "char(40)")]
        public string FkPbolinkDescriptor { get; set; }
        [Column("PBOLinkDescriptorSetID")]
        [StringLength(30)]
        public string PbolinkDescriptorSetId { get; set; }
    }
}
