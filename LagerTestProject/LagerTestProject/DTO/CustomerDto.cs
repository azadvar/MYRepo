using LagerTestProject.Entites;

namespace LagerTestProject.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<AddressDto> Addresses { get; set; }
    }
}
