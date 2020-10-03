using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }
        public Address(int addressID)
        {
            AddressID = addressID;
        }
        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;
            if (string.IsNullOrWhiteSpace(StreetLine2)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(State)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;

            return isValid;
        }

    }
}
