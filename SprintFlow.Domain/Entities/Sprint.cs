using System;

namespace SprintFlow.Domain.Entities
{
    public class Sprint
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid BoardId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Goal { get; set; } = string.Empty;
    }
}
