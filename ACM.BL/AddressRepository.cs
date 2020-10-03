using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressID)
        {
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "A",
                StreetLine2 = "B",
                PostalCode = "1234",
                City = "C",
                State = "D",
                Country = "E",
            };
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "AA",
                StreetLine2 = "AB",
                PostalCode = "A1234",
                City = "AC",
                State = "AD",
                Country = "AE",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "BA",
                StreetLine2 = "BB",
                PostalCode = "B1234",
                City = "BC",
                State = "BD",
                Country = "BE",
            };
            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //call save to db
                    }
                    else
                    {
                        //call update to db
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
