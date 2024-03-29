﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class AddressDbRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(1);

            //Code to retrieve the content from db

            //Hard coded sample
            if(address.AddressId == 1)
            {
                address.StreetLine1 = "123 Abc";
                address.StreetLine2 = "Abc apartment";
                address.City = "Abc";
                address.State = "Abc";
                address.Country = "Abc";
                address.PostalCode = "1231AF";
                address.AddressType = AddressTypes.Home;
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            List<Address> addressList = new List<Address>();
            //Adding the first address to a list of addresses
            Address address1 = new Address(1)
            {
                StreetLine1 = "123 Abc",
                StreetLine2 = "Abc apartment",
                City = "Abc",
                State = "Abc",
                Country = "Abc",
                PostalCode = "1231AF",
                AddressType = AddressTypes.Home
            };
            addressList.Add(address1);
            Address address2 = new Address(2)
            {
                StreetLine1 = "123 Xyz",
                StreetLine2 = "Xyxzapartment",
                City = "Xyz",
                State = "Xyz",
                Country = "Xyz",
                PostalCode = "1231XZ",
                AddressType = AddressTypes.Work
            };
            addressList.Add(address2);
            

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
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // Call an update stored procedure
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
