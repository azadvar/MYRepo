using LagerTestProject.Entites;

namespace LagerTestProject.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<AddressModel> Addresses { get; set; }
    }
}
