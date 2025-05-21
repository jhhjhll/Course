using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public long Area { get; set; }
        public string PartWorld { get; set; }
        public string AdditionalFacts { get; set; }

        public Country()
        {
            // щоб уникнути null і помилки
            Name = string.Empty;
            Capital = string.Empty;
            PartWorld = string.Empty;
            AdditionalFacts = string.Empty;
        }
    }
}
