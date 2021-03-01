using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JHATwitterApp.Models
{
    public class Data
    {
        public string author_id { get; set; }
        public DateTimeOffset created_at { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }
}
