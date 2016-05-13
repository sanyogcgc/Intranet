using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tb_trainer_feedback
    {
        public int FID { get; set; }
        public Nullable<int> TC_ID { get; set; }
        public string Training { get; set; }
        public string trainer_name { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string overall_trainig { get; set; }
        public string complete_objective { get; set; }
        public string group_enganement { get; set; }
        public string listning_particiopents { get; set; }
        public string overall_effectiveness { get; set; }
        public string time_training { get; set; }
        public string training_session { get; set; }
        public string overall_programme { get; set; }
        public string like_seesion { get; set; }
        public string dislike_session { get; set; }
        public string suggest_traing_priogram { get; set; }
        public string Rating { get; set; }
    }
}
