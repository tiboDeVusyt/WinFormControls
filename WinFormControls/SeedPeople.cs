using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormControls
{
    public class SeedPeople
    {
        public static List<Person> People { get; protected set; }  = new List<Person>();

        public static List<Person> Getpersons()
        {
            People.Add(new Person() {Id = 1,FirstName = "Anass",LastName = "Eli" ,Age = 27,IsVIp = false ,CountryId =1 });
            People.Add(new Person() {Id = 2,FirstName = "Florian",LastName = "Esprit" ,Age = 24,IsVIp = false ,CountryId =2 });
            People.Add(new Person() {Id = 3,FirstName = "Wouter",LastName = "Van Leare" ,Age = 21,IsVIp = false ,CountryId =3 });
            People.Add(new Person() {Id = 4,FirstName = "Olga",LastName = "Char" ,Age = 25,IsVIp = false ,CountryId =1 });
            People.Add(new Person() {Id = 5,FirstName = "tibo",LastName = "de vuyst" ,Age = 20,IsVIp = true ,CountryId =1 });
            People.Add(new Person() {Id = 6,FirstName = "Anass",LastName = "Esp" ,Age = 21,IsVIp = false ,CountryId =3 });
            return People;
        }
    }
}
