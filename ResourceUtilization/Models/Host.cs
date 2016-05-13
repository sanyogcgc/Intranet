using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceUtilization.Models
{
    public class Host
    {
        public string CustNo { get; set; }

        public string Company { get; set; }

        public bool UseThreshold1 { get; set; }

        public string Threshold1 { get; set; }

        public string ApproverEmail1 { get; set; }

        public string Threshold2 { get; set; }

        public string ApproverEmail2 { get; set; }

        public bool UseThreshold3 { get; set; }

        public string Threshold3 { get; set; }

        public string ApproverEmail3 { get; set; }
    }
}