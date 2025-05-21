using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class CountryСollection
    {
        private List<Country> countries = new List<Country>();

        public int Count => countries.Count;
        public CountryСollection()
        {
            countries = new List<Country>();
        }

        public List<Country> GetAllInfo()
        {
            return new List<Country>(countries);
        }

        public void SetAllInfo(List<Country> newList)
        {
            countries = newList ?? new List<Country>();
        }

        public void Add(Country country)
        {
            countries.Add(country);
        }

        public void UpdateAtIndex(int index, Country newInfo)
        {
            if (index >= 0 && index < countries.Count)
                countries[index] = newInfo;

        }

        public void DeleteAtIndex(int index)
        {
            if (index >= 0 && index < countries.Count)
                countries.RemoveAt(index);
        }
        public Country GetAtIndex(int index)
        {
            if (index >= 0 && index < countries.Count)
                return countries[index];
            else
                return null;
        }

        public int GetAtIndexOf(Country country)
        {
            return countries.IndexOf(country);
        }

        public List<Country> Search(string searchInfo)
        {

            var searchResult = countries.Where(i =>
            i.Name.ToLower().Contains(searchInfo) ||
            i.Capital.ToLower().Contains(searchInfo) ||
            i.PartWorld.ToLower().Contains(searchInfo)).ToList();

            return searchResult;
        }
    }
}
