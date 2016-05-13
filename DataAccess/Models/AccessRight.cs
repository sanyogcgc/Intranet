using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class AccessRight
    {
        public int security_id { get; set; }
        public Nullable<byte> TarList { get; set; }
        public Nullable<byte> AddNewTar { get; set; }
        public Nullable<byte> MyProfile { get; set; }
        public Nullable<byte> Reports { get; set; }
        public Nullable<byte> ReleasedNotes { get; set; }
        public Nullable<byte> Administration { get; set; }
    }
}
