using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string WalletAdd { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
    }
}
