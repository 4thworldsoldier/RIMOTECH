using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIMOTECH.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public List<Moviestore> Moviestores { get; set; }
    }
}
