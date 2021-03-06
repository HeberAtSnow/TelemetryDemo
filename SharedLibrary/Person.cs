﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary
{
    public class Person
    {
        public int ID { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public override string ToString() => $"ID {ID}; FirstName: {FirstName} LastName {LastName}";
        
    }
}
