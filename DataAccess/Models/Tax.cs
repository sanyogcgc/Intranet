using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Tax
    {
        public int Tax_Id { get; set; }
        public Nullable<double> Tax_Rate { get; set; }
        public string Tax_Name { get; set; }
        public string Fin_Year_Id { get; set; }
    }
}
