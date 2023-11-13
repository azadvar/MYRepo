using System.ComponentModel.DataAnnotations.Schema;

namespace LagerTestProject.Entites
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Price { get; set; }
      
        public UnitsEntity Unit { get; set; }
    }
}
