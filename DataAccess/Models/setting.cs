using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class setting
    {
        public int settings_id { get; set; }
        public string file_extensions { get; set; }
        public string file_path { get; set; }
        public string notify_new_from { get; set; }
        public string notify_new_subject { get; set; }
        public string notify_new_body { get; set; }
        public string notify_change_from { get; set; }
        public string notify_change_subject { get; set; }
        public string notify_change_body { get; set; }
        public Nullable<byte> upload_enabled { get; set; }
    }
}
