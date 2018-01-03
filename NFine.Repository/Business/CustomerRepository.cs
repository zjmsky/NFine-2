﻿using NFine.Data;
using NFine.Domain.Entity.Business;
using NFine.Domain.IRepository.Business;

namespace NFine.Repository.Business
{
    public class CustomerRepository : RepositoryBase<CustomerEntity>, ICustomerRepository
    {
    }
}
