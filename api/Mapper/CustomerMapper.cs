using api.DTOs.Customers;
using api.Models;
using System.Runtime.CompilerServices;

namespace api.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerDTO ToCustomerDTO(this Customer customerModel)
        {
            CustomerDTO customer = new()
            {
                CustId = customerModel.CustId,
                FirstName = customerModel.FirstName,
                LastName = customerModel.LastName,
                MiddleName = customerModel.MiddleName,
                DateAdded = customerModel.DateAdded,
                LastModified = customerModel.LastModified,
                LastRental = customerModel.LastRental

            };
            return customer;
        }
        public static Customer ToCustomerFromCreateDTO(this CreateCustomerRequestDTO customerDTO)
        {
            return new Customer
            {
                FirstName = customerDTO.FirstName,
                MiddleName = customerDTO.MiddleName,
                LastName = customerDTO.LastName,
                DateAdded = customerDTO.DateAdded,
                LastModified = customerDTO.LastModified,
                LastRental = customerDTO.LastRental
            };

        }
    }
}
