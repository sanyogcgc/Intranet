using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TarType
    {
        public int type_id { get; set; }
        public string typename { get; set; }
        public string Description { get; set; }
        public Nullable<byte> Intern { get; set; }
        public Nullable<byte> Extern { get; set; }
    }
}
