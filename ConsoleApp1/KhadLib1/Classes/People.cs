using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhadLib1.Classes
{
    public class People
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public TimeSpan Age => DateTime.Now.Subtract(Birthdate);

        public People() { }
    }
}
