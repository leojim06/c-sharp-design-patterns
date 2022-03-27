using Builder.Contracts;
using Builder.Entities;
using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContractBuilder platinoContract = new PlatinoContract();
            ContractDirector director = new ContractDirector(platinoContract);

            Person contractHolder = new Person()
            {
                FirstName = "Pedro",
                LastName = "Perez",
                MainAddress = "Main addres",
                PhoneNumber = "+11 1234 455 125",
                Birthday = DateTime.Now.AddYears(-50).AddMonths(-4).AddDays(-12)
            };

            List<Person> beneficiaries = new List<Person>()
            {
                new Person() { FirstName = "Benef", LastName = "1", MainAddress = "MA1", PhoneNumber = "PN1",  Birthday = DateTime.Today.AddYears(-50) },
                new Person() { FirstName = "Benef", LastName = "2", MainAddress = "MA2", PhoneNumber = "PN2",  Birthday = DateTime.Today.AddYears(-10) },
            };

            Contract contract = director.GenerateContract(contractHolder, beneficiaries);

            Console.WriteLine(contract.ToString());

            //ContractBuilder contractBuilder = new ZafiroContract();
            //ContractDirector directorLight = new ContractDirector(contractBuilder);

            //Contract contractLight = directorLight.GenerateLightContract(contractHolder);
        }
    }
}