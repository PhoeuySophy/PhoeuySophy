
using FormCustomer.Models;

namespace FormCustomer.Repository

{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        bool Create(Customer customer);
        bool Update(Customer customer);
        bool Delete(int CustomerId);
    }
}
