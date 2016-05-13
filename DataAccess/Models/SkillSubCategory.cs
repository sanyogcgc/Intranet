using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SkillSubCategory
    {
        public int SkillSubCatId { get; set; }
        public Nullable<int> SkillCatId { get; set; }
        public string SubCategory { get; set; }
    }
}
