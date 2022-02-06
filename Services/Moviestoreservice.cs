using RIMOTECH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIMOTECH.Services
{
    public interface IMoviestoreservice
    {
       List<Moviestore> Get(int countrycode);

    }
    public class Moviestoreservice : IMoviestoreservice
    {
        private DBCONTEXT _context;

        public Moviestoreservice(DBCONTEXT dBCONTEXT)
        {
            _context = dBCONTEXT;
        }

        public List<Moviestore> Get(int countrycode)
        {
            var  stores = _context.Moviestores
                    .Where(x => x.countrycode == countrycode)
                    .OrderBy(store => countrycode)
                    .ToList();
            return stores;
        }
    }
}
