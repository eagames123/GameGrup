using GameGrup.Core.Entity;

namespace GameGrup.Project.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string SeoUrl { get; set; }

        public int CategoryId { get; set; }
        
        public string ImageUrl { get; set; }
        
        public decimal Price { get; set; }
        
        public bool IsActive { get; set; }

        public string Desciption { get; set; }        
    }
}
