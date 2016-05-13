using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class file
    {
        public int file_id { get; set; }
        public string file_name { get; set; }
        public Nullable<int> issue_id { get; set; }
        public Nullable<System.DateTime> date_uploaded { get; set; }
        public Nullable<int> uploaded_by { get; set; }
    }
}
