using System.ComponentModel.DataAnnotations;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class Ao3Tag
    {
        public required int Id { get; set; }
        [MaxLength(150)]
        public required string Text { get; set; }
        public string? SysNotes { get; set; } // Internal notes about this tag
    }
}
