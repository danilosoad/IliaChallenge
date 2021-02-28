using ApiRestFul.Application.Interfaces;
using ApiRestFul.Domain.Entities;
using ApiRestFul.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Application
{
    public class ApiAppService : IApiAppService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IUnityOfWork _unityOfWork;
        public ApiAppService(ICustomerRepository customerRepo, IUnityOfWork unityOfWork)
        {
            _customerRepo = customerRepo;
            _unityOfWork = unityOfWork;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepo.Add(customer);
            _unityOfWork.Commit();
        }

        public void DeleteCustomer(int id)
        {
            var costumer = _customerRepo.GetCostumerById(id);

            if (costumer != null)
            {
                _customerRepo.Delete(costumer);
                _unityOfWork.Commit();
            }
            else
            {
                _unityOfWork.RollBack();
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepo.GetCustomers();
        }

        public dynamic GetCustomersById(int id)
        {
            return _customerRepo.GetCostumerById(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            var custumer = _customerRepo.GetCostumerById(customer.Id);

            if (custumer != null)
            {
                _customerRepo.Edit(customer);
                _unityOfWork.Commit();
            }
            else
            {
                _unityOfWork.RollBack();
            }

        }

    }
}
