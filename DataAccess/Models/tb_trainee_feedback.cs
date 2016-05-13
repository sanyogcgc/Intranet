using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tb_trainee_feedback
    {
        public int FID { get; set; }
        public Nullable<int> empp_id { get; set; }
        public string Training { get; set; }
        public string trainer_name { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string imp_tra { get; set; }
        public string com_obj { get; set; }
        public string clarity_cov { get; set; }
        public string pace_pres { get; set; }
        public string covera_mater { get; set; }
        public string clarity_commu { get; set; }
        public string prserna_trainer { get; set; }
        public string knowedge_trainer { get; set; }
        public string question_handling { get; set; }
        public string overall_effect { get; set; }
        public string time_training { get; set; }
        public string training_session { get; set; }
        public string content_used { get; set; }
        public string overall_programme { get; set; }
        public string repaeat_session { get; set; }
        public string like_session { get; set; }
        public string dislike_session { get; set; }
        public string key_learningq { get; set; }
        public string suggest_programme { get; set; }
        public string Rating { get; set; }
    }
}
