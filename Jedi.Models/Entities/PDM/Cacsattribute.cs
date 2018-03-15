using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSAttribute")]
    public partial class Cacsattribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("GSMDataObjectType")]
        public int? GsmdataObjectType { get; set; }
        [StringLength(256)]
        public string DataSource { get; set; }
    }
}
