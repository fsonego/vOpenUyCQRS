﻿using System.Collections.Generic;

namespace vOpenUYCQRS.Application.Customers.Queries.GetCustomersList
{
    public class CustomersListVm
    {
        public IList<CustomerLookupDto> Customers { get; set; }
    }
}
