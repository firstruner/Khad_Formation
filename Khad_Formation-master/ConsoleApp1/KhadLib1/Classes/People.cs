﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhadLib1.Classes
{
                        // Mieux présenter le code - ici serializable s'applique
    [Serializable()]    // à la classe et non au namespace
    public class People
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public TimeSpan Age => DateTime.Now.Subtract(Birthdate);

        public People() { }

        public People(string first,string last,DateTime birth)
        {
            this.Firstname = first;
            this.Lastname = last;
            this.Birthdate = birth;
        }

        public override string ToString()
        {
            return ("les infos Firstname= " + Firstname+ ",Lastname="+ Lastname+ ",Birthdate="+Birthdate);
        }
    }
}
