using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonEASectionCellTemplate")]
    public partial class CommonEasectionCellTemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkRowTemplate", TypeName = "char(40)")]
        public string FkRowTemplate { get; set; }
        [Required]
        [Column("fkColumnTemplate", TypeName = "char(40)")]
        public string FkColumnTemplate { get; set; }
        [Column("fkExtendedAttributeType", TypeName = "char(40)")]
        public string FkExtendedAttributeType { get; set; }
    }
}
