using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Skill
    {
        public int SkillId { get; set; }
        public Nullable<int> SkillSubCatId { get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }
    }
}
