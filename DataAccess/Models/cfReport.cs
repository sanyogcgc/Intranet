using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class cfReport
    {
        public string Training { get; set; }
        public string Trainer { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public Nullable<int> TEAOS1 { get; set; }
        public Nullable<int> TEAOS2 { get; set; }
        public Nullable<int> TEAOS3 { get; set; }
        public Nullable<int> TEAOS4 { get; set; }
        public Nullable<int> TEAOS5 { get; set; }
        public Nullable<int> FOT1 { get; set; }
        public Nullable<int> FOT2 { get; set; }
        public Nullable<int> FOT3 { get; set; }
        public Nullable<int> FOT4 { get; set; }
        public Nullable<int> FOT5 { get; set; }
        public Nullable<int> GFbk1 { get; set; }
        public Nullable<int> GFbk2 { get; set; }
        public Nullable<int> GFbk3 { get; set; }
        public Nullable<int> GFbk4 { get; set; }
    }
}
