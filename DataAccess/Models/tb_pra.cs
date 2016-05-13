using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tb_pra
    {
        public int PRAID { get; set; }
        public Nullable<int> EMPID { get; set; }
        public Nullable<int> Rmempid { get; set; }
        public string year { get; set; }
        public string month { get; set; }
        public Nullable<int> clientSatisfaction { get; set; }
        public Nullable<int> clientIntrenalCommu { get; set; }
        public Nullable<int> Errorfree { get; set; }
        public Nullable<int> utilization { get; set; }
        public Nullable<int> problrlSolving { get; set; }
        public Nullable<int> Attitude { get; set; }
        public Nullable<int> Initiatives { get; set; }
        public Nullable<int> Discipline { get; set; }
        public Nullable<int> openness { get; set; }
        public Nullable<int> participate { get; set; }
        public Nullable<int> Learning { get; set; }
        public Nullable<int> knoowledge { get; set; }
        public Nullable<int> managinExpectation { get; set; }
        public Nullable<double> Average { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
    }
}
