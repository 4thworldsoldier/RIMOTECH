using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIMOTECH.Models
{
    public class Moviestore
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string location { get; set; }
        public int countrycode { get; set; }
        public List<Movie>? movies { get; set; }
        public List<Customer>? customers { get; set; }
        //public Country COUNTRY { get; set; }
    }
}
