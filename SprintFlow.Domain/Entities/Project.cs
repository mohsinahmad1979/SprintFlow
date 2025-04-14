namespace SprintFlow.Domain.Entities
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required string Name { get; set; }

        public required string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
       
    }
}
