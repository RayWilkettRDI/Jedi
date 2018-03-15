using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TestingProtocolName
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("protocolname")]
        [StringLength(128)]
        public string Protocolname { get; set; }
        [Required]
        [Column("fkTestingProtocol", TypeName = "char(40)")]
        public string FkTestingProtocol { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
