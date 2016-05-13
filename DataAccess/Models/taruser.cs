using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class taruser
    {
        public int user_id { get; set; }
        public Nullable<byte> security_level { get; set; }
        public Nullable<short> notify_new { get; set; }
        public Nullable<short> notify_original { get; set; }
        public Nullable<short> notify_reassignment { get; set; }
        public Nullable<short> allow_upload { get; set; }
        public Nullable<short> defaultprofile { get; set; }
        public Nullable<short> closedtardays { get; set; }
    }
}
