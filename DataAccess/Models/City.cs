using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class City
    {
        public int CityID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string CityName { get; set; }
    }
}
