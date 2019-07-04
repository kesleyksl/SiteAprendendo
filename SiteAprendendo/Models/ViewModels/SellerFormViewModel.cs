using System.Collections.Generic;

namespace SiteAprendendo.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }

    }
}
