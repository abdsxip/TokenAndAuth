using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomersBLL : ICustomers
    {

        private readonly DBContextSingleTon _dbContext;

        public CustomersBLL()
        {
            _dbContext = DBContextSingleTon.GetDBContextInstance();
        }

        public bool CreateCustomers(Customers obj)
        {
            throw new NotImplementedException();
        }

        public List<Customers> CustomersList()
        {
            List<Customers> customers = _dbContext.customers.ToList();
            return customers;
        }
    }
}
