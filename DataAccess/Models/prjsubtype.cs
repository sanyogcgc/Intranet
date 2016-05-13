using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class prjsubtype
    {
        public int pSubTypeId { get; set; }
        public Nullable<int> pTypeId { get; set; }
        public string SubTypeDesc { get; set; }
    }
}
