using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMVC.Models
{
    public class Department
    {
        // Props
        public int Id { get; set; }
        public string Name { get; set; }

        // Associacao entre 'Department' e 'Seller' - 1 'Department' tem varios 'Sellers'.
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        // Constructors
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Methods
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
