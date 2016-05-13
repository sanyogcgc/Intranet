using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Client
    {
        public int ID { get; set; }
        public string Client_Name { get; set; }
        public Nullable<int> Lead_Source { get; set; }
        public Nullable<int> City_Code { get; set; }
        public Nullable<int> Directory { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string emailid { get; set; }
        public string ClientCode { get; set; }
        public string ClientC { get; set; }
    }
}
