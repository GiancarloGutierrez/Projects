using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giancarlo_Gutierrez_A1.Models
{
    public class passed
    {
        public int userId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public passed(int id, string first, string last)
        {
            userId = id;
            First = first;
            Last = last;
        }
    }
}
