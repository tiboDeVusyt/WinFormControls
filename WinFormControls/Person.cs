using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormControls
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsVIp { get; set; }
        public int CountryId { get; set; }

        public override string ToString()
        {
            return $" {Id}-{FirstName} {LastName} {Age} {IsVIp} {CountryId}";
        }
    }
}
