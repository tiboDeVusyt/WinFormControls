using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormControls
{
    public class seedCountry
    {
        public static List<Country> Countries { get; set; } = new List<Country>();
        public static List<Country> GetCountries()
        {
            Countries.Add(new Country() { Id = 1, Name = "Belgium" });
            Countries.Add(new Country() { Id = 2, Name = "France" });
            Countries.Add(new Country() { Id = 3, Name = "UK" });
            Countries.Add(new Country() { Id = 4, Name = "Germany" });
            return Countries;
        }

    }
}
