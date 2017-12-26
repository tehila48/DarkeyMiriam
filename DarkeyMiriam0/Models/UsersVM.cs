using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkeyMiriam0.Models
{
    public class UsersVM
    {
        public int IdUs { get; set; }
        public string NameUs { get; set; }
        public string PasswordUs { get; set; }
        public int CodeStatusUs { get; set; }

        public int IdSta { get; set; }
        public int CodeSta { get; set; }
        public string StatusSta { get; set; }
    }
}