using System;

namespace Builder.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string MainAddress { get; set; }

        public bool IsOfLegalAge()
        {
            return DateTime.Today.AddTicks(-Birthday.Ticks).Year - 1 > 18;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
