using LagerTestProject.Entites;

namespace LagerTestProject.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Price { get; set; }

        public UnitsEntity Unit { get; set; }
    }
}
