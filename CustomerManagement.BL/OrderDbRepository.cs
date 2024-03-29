﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class OrderDbRepository
    {

        public Order RetrieveById(int orderId)
        {
            Order order = new Order(1);
            //Code for retrieving the customer based on the Id

            //Hard coded
            if(order.OrderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 12, 14, 25, 45, new TimeSpan(4, 0, 0));
            }
            Console.WriteLine($"ToString Overrided in the Order class : {order.ToString()}");
            return order;
           
            

        }
        
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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
