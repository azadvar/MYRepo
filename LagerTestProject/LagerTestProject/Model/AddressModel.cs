using LagerTestProject.Entites;

namespace LagerTestProject.Model
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Land { get; set; }
        public string City { get; set; }
        public String Street { get; set; }
        public int Nummber { get; set; }
        public string PostalCode { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
