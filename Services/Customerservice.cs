using Microsoft.EntityFrameworkCore;
using RIMOTECH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIMOTECH.Services
{
    public interface ICustomerservice
    {
        //void Register(Customer model);
        Task RegisterAsync(Customer model);

        Task<IEnumerable<Customer>> GetCustomersAsyn();

        Task<Customer> Getcustomerasync(int cardnumber);

        Task<IEnumerable<Customer>> GetcustomerbystoreAsync(int storeid);

        Task Delete(int customerid);
        //Task GetCardAsyn();
    }


    public class Customerservice : ICustomerservice
    {
        private DBCONTEXT _context;
        public Customerservice(DBCONTEXT context)
        {
            _context = context;
        }
        //public void Register(Customer model)
        //{
        //    _context.Customers.Add(model);
        //    _context.SaveChanges();
        //}
        public async Task RegisterAsync(Customer model)
        {
            if (_context.Customer.Any(x => x.Id == model.Id))
            {
                throw new KeyNotFoundException("customer already exist");
            }
            _context.Customer.Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Customer>> GetCustomersAsyn()
        {
            var customers = await _context.Customer.ToListAsync();
            return customers;
        }
        public async Task<Customer> Getcustomerasync(int customerid)
        {
            var customer = await getCustomer(customerid);
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetcustomerbystoreAsync(int storeid)
        {
            var cards = await getCustomers(storeid);
            return cards;
        }


        public async Task Delete(int customerid)
        {          
            var customer = await getCustomer(customerid);
            if (customer == null)
            {
                throw new KeyNotFoundException("customer not found");
            }
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
        }

        private async Task<Customer> getCustomer(int customerid)
        {
            var customers = await _context.Customer.FindAsync(customerid);
            if (customers == null) throw new KeyNotFoundException("customer not found");
            return customers;
        }
        private async Task<IEnumerable<Customer>> getCustomers(int storeid)
        {
            var customers = await _context.Customer.Where(x => x.MoviestoreId == storeid).OrderBy(x => x.Id).ToListAsync();
            if (customers == null) throw new KeyNotFoundException("customer not found");
            return customers;
        }

    }
}
