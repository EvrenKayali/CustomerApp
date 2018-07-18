using CustomerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApp.Services
{
    public interface ICustomerService
    {
        CustomerSearchResultApiModel Search(string searchTerm, int pageSize, int pageNumber);
    }
}
