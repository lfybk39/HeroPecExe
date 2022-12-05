﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPecApp.ConnectionFTP
{
    [Table("heropecuser")]
    public class User
    {
        public int id { get; set; }
        public string userid { get; set; }
        public string passwd { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string phone { get; set; }
    }
}
