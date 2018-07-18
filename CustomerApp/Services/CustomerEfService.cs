namespace CustomerApp.Services
{
    using CustomerApp.DAL;
    using CustomerApp.Models;
    using System.Linq;

    public class CustomerEfService : ICustomerService
    {
        public readonly CustomerContext db;
        public CustomerEfService(CustomerContext db)
        {
            this.db = db;
        }
        public CustomerSearchResultApiModel Search(string searchTerm, int pageSize, int pageNumber)
        {
            var model = new CustomerSearchResultApiModel();
            var query = db.Customers.Where(c => c.Name.Contains(searchTerm) ||
                                                c.Id.Contains(searchTerm));

            model.ResultCount = query.Count();

            model.PageCount = (model.ResultCount + pageSize - 1) / pageSize;

            var skipVal = (pageNumber - 1) * pageSize;

          model.Results = query.Skip(skipVal).Take(pageSize);
            return model;
        }
    }
}