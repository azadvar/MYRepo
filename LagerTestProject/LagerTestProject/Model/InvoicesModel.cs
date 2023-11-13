using LagerTestProject.Entites;
using System.Collections.ObjectModel;

namespace LagerTestProject.Model
{
    public class InvoicesModel
    {
        public int Id { get; set; }
        public DateTime Creatat { get; set; }
        public Collection<InvoiceDetailModel> InvoiceDetails { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
