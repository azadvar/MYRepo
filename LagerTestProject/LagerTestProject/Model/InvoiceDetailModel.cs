using LagerTestProject.Entites;

namespace LagerTestProject.Model
{
    public class InvoiceDetailModel
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public int Count { get; set; }
        public InvoicesModel Invoices { get; set; }
        public ProductModel products { get; set; }
    }
}
