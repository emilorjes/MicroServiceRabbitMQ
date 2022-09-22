using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : ILoggable
    {
        public Customer(): this(0) { }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }
        public override string ToString()
        {
            return FullName;
        }

        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return $"{CustomerId}: {FullName} Email: {EmailAdress}";
        }
    }
}
