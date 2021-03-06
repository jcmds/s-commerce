using SC.Core.Entities;

namespace SC.Domain.Entities
{
    public class Category : IEntity<int>
    {
        protected Category()
        {
        }

        public Category(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public string Description { get; private set; }
        public int Id { get; private set; }
    }
}