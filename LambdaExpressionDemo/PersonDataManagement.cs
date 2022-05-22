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
            personsList.Add(new Person { SSN = 1, Name = "Chetana", Address = "dhule", Age = 23 });
            personsList.Add(new Person { SSN = 2, Name = "Teena", Address = "amalner", Age = 25 });
            personsList.Add(new Person { SSN = 3, Name = "reena", Address = "mumbai", Age = 60 });
            personsList.Add(new Person { SSN = 4, Name = "meena", Address = "pune", Age = 75 });
            personsList.Add(new Person { SSN = 5, Name = "shila", Address = "nashik", Age = 14 });
        }
        public void GetTopRecords()
        {
            Console.WriteLine("*****************Get Top Records *******************");
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
        public void CheckingForTeenagePerson()
        {
            Console.WriteLine("*****************Checking For Teenage Person *******************");
            if (this.personsList.Any(x =>(x.Age>=13 && x.Age < 18)))
            {
                Console.WriteLine("Yes, We have Some teen-agers in the list");
            }
            else
            {
                Console.WriteLine("No,We dont have teen-agers in the list ");
            }
        }
        public void AverageRecord()
        {
            Console.WriteLine("***************** Average Age *******************");
            var result = this.personsList.Average(x => x.Age);
            Console.WriteLine("Average Age In The List :"+" " +result);
        }
        public void GetName()
        {
            Console.WriteLine("*****************Name Exist Or Not*******************");
            var result = this.personsList.Where(x => x.Name == "chetana");
            if (result != null)
            {
                Console.WriteLine("Name present in list");
            }
            else
            {
                Console.WriteLine("Name is not present in List");
            }
        }
        public void SkipRecord()
        {
            Console.WriteLine("*****************Skip Record*******************");
            var result = this.personsList.Skip(this.personsList.Where(x => x.Age < 60).Count());
            Display(result);
        }
        public void RemoveRecord()
        {
            Console.WriteLine("*****************Remove Name*******************");
            Person result = this.personsList.Find(x => x.Name == "Chetana");
            this.personsList.Remove(result);
            Display(this.personsList);
        }
    }
}
