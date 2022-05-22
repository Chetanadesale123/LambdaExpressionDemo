using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDemo
{
    public class PersonDataManagement
    {
        List<Person> personsList = new List<Person>();
        public void AddDefaultData()
        {
            personsList.Add(new Person { SSN = 1, Name = "Chetana ", Address = "dhule", Age = 23 });
            personsList.Add(new Person { SSN = 2, Name = "Teena", Address = "amalner", Age = 25 });
            personsList.Add(new Person { SSN = 3, Name = "reena ", Address = "mumbai", Age = 60 });
            personsList.Add(new Person { SSN = 4, Name = "meena ", Address = "pune", Age = 75 });
            personsList.Add(new Person { SSN = 5, Name = "shila ", Address = "nashik", Age = 30 });
        }
        public void GetTopRecords()
        {
            var result = this.personsList.Where(x => x.Age < 60).Take(2);
            Display(result);
        }
        public void Display(IEnumerable<Person> personList)
        {
            foreach (var person in personList)
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + " " + person.Age);
            }
        }
    }
}
