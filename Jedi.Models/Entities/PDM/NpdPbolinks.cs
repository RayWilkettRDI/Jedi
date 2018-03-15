using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdPBOLinks")]
    public partial class NpdPbolinks
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkPBO", TypeName = "char(40)")]
        public string FkPbo { get; set; }
        [Column("fkPBOLinkDescriptor", TypeName = "char(40)")]
        public string FkPbolinkDescriptor { get; set; }
        [Column("fkEntity", TypeName = "char(40)")]
        public string FkEntity { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        public bool IsCustomAssociation { get; set; }
    }
}
