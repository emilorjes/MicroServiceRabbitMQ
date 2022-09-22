using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new(addressId);
            if(addressId == 1)
            {
                address.AdressType = 1;
                address.StreetLineOne = "Bag End";
                address.StreetLineTwo = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AdressType = 1,
                StreetLineOne = "Bag End",
                StreetLineTwo = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            addressList.Add(address);
            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
