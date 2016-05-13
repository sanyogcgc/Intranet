using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MailSetting
    {
        public int i_serverid { get; set; }
        public Nullable<int> i_portout { get; set; }
        public Nullable<int> i_portin { get; set; }
        public string c_username { get; set; }
        public string c_password { get; set; }
        public string c_from { get; set; }
        public string c_fromdisp { get; set; }
        public string c_smtpserverin { get; set; }
        public string c_smtpserverout { get; set; }
        public string i_status { get; set; }
    }
}
