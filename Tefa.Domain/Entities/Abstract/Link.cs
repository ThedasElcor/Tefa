namespace Tefa.Domain.Entities.Abstract
{
     public abstract class Link
    {
            public required int Id { get; set; }
            public string? Name { get; set; }
            public required string Url { get; set; }
            public string? Label { get; set; } // e.g., "Sign-up Form", "Discord", "Schedule"
    }
}
