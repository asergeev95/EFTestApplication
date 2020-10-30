using System;

namespace Core
{
    public class Relative
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}