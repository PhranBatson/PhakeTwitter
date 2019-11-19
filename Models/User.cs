using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhakeTwitter.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Tweet> Tweets { get; set; }
    }
}
