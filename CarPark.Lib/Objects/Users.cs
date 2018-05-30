using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Lib.Objects
{
    public enum AccessLevel { FullAccess = 1, LimitedAccess}
    class Users
    {
        public string Login { get; set; }
        public int Password { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public string Project { get; set; }
    }
}
