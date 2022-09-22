using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address() { }
        public Address(int adressId)
        {
            AdressId = adressId;
        }
        public int AdressId { get; private set; }
        public string StreetLineOne { get; set; }
        public string StreetLineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AdressType { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if(PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
