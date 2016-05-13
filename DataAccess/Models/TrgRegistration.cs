using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgRegistration
    {
        public int TrgRegNo { get; set; }
        public Nullable<int> TrgSchID { get; set; }
        public string Invited { get; set; }
        public string Attendance { get; set; }
        public Nullable<decimal> PreTestScore { get; set; }
        public Nullable<decimal> PostTestScore { get; set; }
        public int TrgFbkEmpID { get; set; }
        public string SessionObjective { get; set; }
        public Nullable<short> TopicEAOS1 { get; set; }
        public Nullable<short> TopicEAOS2 { get; set; }
        public Nullable<short> TopicEAOS3 { get; set; }
        public Nullable<short> TopicEAOS4 { get; set; }
        public Nullable<short> TopicEAOS5 { get; set; }
        public Nullable<short> FbkoTrainer1 { get; set; }
        public Nullable<short> FbkoTrainer2 { get; set; }
        public Nullable<short> FbkoTrainer3 { get; set; }
        public Nullable<short> FbkoTrainer4 { get; set; }
        public Nullable<short> FbkoTrainer5 { get; set; }
        public Nullable<short> GeneralFbk1 { get; set; }
        public Nullable<short> GeneralFbk2 { get; set; }
        public Nullable<short> GeneralFbk3 { get; set; }
        public Nullable<short> GeneralFbk4 { get; set; }
        public string FbkQuestion1 { get; set; }
        public string FbkQuestion2 { get; set; }
        public string FbkQuestion3 { get; set; }
        public string FbkQuestion4 { get; set; }
        public string FbkQuestion5 { get; set; }
        public Nullable<bool> FbkGiven { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
