﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PhakeTwitter.Models
{
    public class Tweet
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }
        [Display(Name = "Post Date / Time")]
        public string PostDate { get; set; }

        public User User { get; set; }

    }
}
