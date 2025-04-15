namespace SprintFlow.Domain.Entities
{
    public class Board
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public Guid ProjectId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
