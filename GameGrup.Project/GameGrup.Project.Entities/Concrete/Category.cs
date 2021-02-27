using GameGrup.Core.Entity;
using System;

namespace GameGrup.Project.Entities.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }

        public Nullable<int> CategoryId { get; set; }

        public string Name { get; set; }

        public string SeoUrl { get; set; }
    }
}
