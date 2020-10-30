using System;
using System.Collections.Generic;

namespace Core
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public List<Relative> Relatives { get; set; }
    }
}