using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceUtilization.Models
{
    public class ResourceModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string CurrentBillable { get; set; }
        public string CurrentNonBillable { get; set; }
        public string NextBillable { get; set; }
        public string NextNonBillable { get; set; }
        public string InvoiceHours { get; set; }
        public List<ProjectModels> ProjectList { get; set; }
        public ProjectModels SelectedProject { get; set; }
    }
}