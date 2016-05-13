using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblGeographyMaster
    {
        public int GeographyId { get; set; }
        public string GeographyName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
