﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models.Borrowers
{
    // inherits everything from Person
    public class Staff: Person
    {
        public Staff(string idNumber) : base(idNumber) { }
    }
}
