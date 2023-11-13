using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LagerTestProject.Entites
{
    public class InvoicesEntity
    {
        public int Id { get; set; }
        public DateTime Creatat { get; set; }
         public Collection<InvoiceDetailEntity> InvoiceDetails { get; set; }
        public CustomerEntity Customer { get; set; }
        
       
       

    }
}
