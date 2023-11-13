using System.ComponentModel.DataAnnotations.Schema;

namespace LagerTestProject.Entites
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Land { get; set; }
        public string City { get; set; }
        public String Street  { get; set; }
        public int Nummber { get; set; }
        public string PostalCode { get; set; }
        public  CustomerEntity Customer { get; set; }
    }
}
