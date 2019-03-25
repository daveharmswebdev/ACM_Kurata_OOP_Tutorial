using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// retrieves an address by ID
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = "1";
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Nashville";
                address.StateProvince = "TN";
                address.Country = "USA";
                address.PostalCode = "37215";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = "1",
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Nashville",
                StateProvince = "TN",
                Country = "USA",
                PostalCode = "37215"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = "2",
                StreetLine1 = "665 Grassmere",
                City = "Nashville",
                StateProvince = "TN",
                Country = "USA",
                PostalCode = "37111"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves changes to an address
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
