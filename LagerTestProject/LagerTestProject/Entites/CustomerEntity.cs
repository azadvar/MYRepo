using System.ComponentModel.DataAnnotations.Schema;

namespace LagerTestProject.Entites
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<AddressEntity>  Addresses { get; set; }
    }
}
