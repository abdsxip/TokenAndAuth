using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    public interface ICustomers
    {
        List<Customers> CustomersList();
        bool CreateCustomers(Customers obj);
    }
}
