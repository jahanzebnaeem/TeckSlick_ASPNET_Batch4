using System.Collections.Generic;

namespace Teckslick.Batch4.Common
{
    public class Country
    {
        public int ID { get; }
        public string Name { get; set; }

        public Country() { }

        public Country(string name)
        {
            Name = name;
        }

        public Country(int id, string name) : this(name)
        {
            ID = id;
        }
    }
}