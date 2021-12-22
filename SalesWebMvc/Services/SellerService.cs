using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //readonly diz que essa dependencia nao pode ser alterada
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }


        //Retorna uma lista com todos os vendedores do bd
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
