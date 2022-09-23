using System;
namespace Lab4
{
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

        public override string ToString()
        {
			return
				$"Street Address: {StreetAddress}\n" +
				$"City: {City}\n" +
				$"State: {State}\n" +
				$"Postal code: {PostalCode}";
        }
    }
}

