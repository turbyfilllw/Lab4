using System;
namespace Lab4
{
	/// <summary>
	/// Each person will have an address
	/// </summary>
	public class Address
	{
		
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }

		public Address(string address, string city, string state, string postal)
		{
			this.StreetAddress = address;
			this.City = city;
			this.State = state;
			this.PostalCode = postal;
		}

		/// <summary>
		/// Overridden tostring for output
		/// </summary>
		/// <returns>the address information</returns>
        public override string ToString()
        {
			return $"{StreetAddress}|{City}|{State}|{PostalCode}";
        }
    }
}

