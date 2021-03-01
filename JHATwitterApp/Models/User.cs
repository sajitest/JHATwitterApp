using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JHATwitterApp.Models
{
    public class User
    {
        public DateTime created_at { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string username { get; set; }

    }
}
