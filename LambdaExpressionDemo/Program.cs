using System;
namespace LambdaExpressionDemo
{
    class program
    {
        static void Main(string[] args)
        {
            PersonDataManagement management = new PersonDataManagement();
            management.AddDefaultData();
            management.GetTopRecords();
            management.CheckingForTeenagePerson();
        }
    }
}
