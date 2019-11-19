using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhakeTwitter.Models
{
    public class Tweet
    {
        public int ID { get; set; }
        public int UserID { get; }
        public string Text { get; set; }

        public string PostDate { get; set; }

        public User User { get; set; }

    }
}
