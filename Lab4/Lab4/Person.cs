using System;
namespace Lab4
{
	/// <summary>
	/// This class creates a person object
	/// Implements IComparable to sort each object
	/// by last name
	/// </summary>
	public class Person : IComparable
	{

		public string FirstName { get; init; }
		public string LastName { get; set; }
		public Address Address { get; set; }

		/// <summary>
		/// constructor
		/// </summary>
		/// <param name="FirstName"></param>
		/// <param name="LastName"></param>
		/// <param name="address"></param>
		public Person(string FirstName, string LastName, Address address)
		{

			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Address = address;
			
		}

		/// <summary>
		/// Overriden tostring for output
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
			return $"{FirstName}|{LastName}|{Address}";
        }

		/// <summary>
		/// CompareTo method to sort by last name
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>sorted person object by last name</returns>
        public int CompareTo(object? obj)
        {
			Person p = (Person)obj;

			return string.Compare(this.LastName, p.LastName);
        }
    }
}

