using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class GroupCategory
    {
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public Nullable<int> GroupId { get; set; }
        public Nullable<int> CatHeadID { get; set; }
        public string CatHeademailID { get; set; }
    }
}
