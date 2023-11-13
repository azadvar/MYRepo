using LagerTestProject.Entites;

namespace LagerTestProject.DTO
{
    public class InvoiceDetailDto
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public int Count { get; set; }
        public InvoicesEntity Invoices { get; set; }
        public ProductEntity products { get; set; }
    }
}
