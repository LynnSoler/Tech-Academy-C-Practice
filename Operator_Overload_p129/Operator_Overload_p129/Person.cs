﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_p129
{
    public abstract class Person
    {
        public string FirstName; //{ get; set; }
        public string LastName; //{ get; set; }
        public abstract void SayName();
    }
}
