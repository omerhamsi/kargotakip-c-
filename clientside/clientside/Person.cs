﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientside
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Person(int Id,string Name,string Password)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
        }
    }
}
