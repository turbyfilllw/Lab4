using System;
namespace Lab4
{
	public class Person : IComparable
	{

		public string FirstName { get; init; }
		public string LastName { get; set; }
		public Address Address { get; set; }

		public Person(string FirstName, string LastName, Address address)
		{

			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Address = address;
			
		}

        public override string ToString()
        {
			return $"{FirstName}|{LastName}|{Address}";
        }

        public int CompareTo(object? obj)
        {
			Person p = (Person)obj;

			return string.Compare(this.LastName, p.LastName);
        }
    }
}

