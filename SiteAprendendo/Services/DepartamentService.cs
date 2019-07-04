using SiteAprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SiteAprendendo.Services
{

    public class DepartamentService
    {
        private readonly SiteAprendendoContext _context;

        public DepartamentService(SiteAprendendoContext context)
        {
            _context = context;
        }
        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
