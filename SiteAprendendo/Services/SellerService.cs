using SiteAprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SiteAprendendo.Services
{
    public class SellerService
    {
        private readonly SiteAprendendoContext _context;

        public SellerService(SiteAprendendoContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
