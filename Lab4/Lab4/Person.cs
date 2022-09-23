using System;
namespace Lab4
{
	public class Person
	{

		public string FirstName { get; init; }
		public string LastName { get; set; }
		public Address Address { get; set; }

		public Person(string FirstName, string LastName)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			
		}

        public override string ToString()
        {
			return
				$"{FirstName}|{LastName}|{Address}";
        }
    }
}

