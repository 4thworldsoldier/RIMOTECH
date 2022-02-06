using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RIMOTECH.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public bool isActive { get; set; }
        public int MoviestoreId { get; set; }

        //public List<Movie> movies { get; set; }
    }
}
