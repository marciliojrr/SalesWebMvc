using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() // Sincrona, por enquanto
        {
            return _context.Seller.ToList(); // Acessa a fonte de dados relacionadas a tabela Seller e converte para uma lista
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First(); // Define um dept padrao que ja exista enquanto nao resolve problema da chave estrangeira
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
