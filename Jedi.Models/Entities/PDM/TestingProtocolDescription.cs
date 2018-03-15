using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TestingProtocolDescription
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("description")]
        [StringLength(256)]
        public string Description { get; set; }
        [Required]
        [Column("fkTestingProtocol", TypeName = "char(40)")]
        public string FkTestingProtocol { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
