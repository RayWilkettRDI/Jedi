using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("TestingProtocolStatusML")]
    public partial class TestingProtocolStatusMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(4)]
        public string StatusId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
