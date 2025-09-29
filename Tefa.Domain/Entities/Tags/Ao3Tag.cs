using System.ComponentModel.DataAnnotations;

namespace Tefa.Domain.Entities.Tags
{
    public class Ao3Tag // For text intake
    {
        public required int Id { get; set; }
        [MaxLength(150)]
        public required string Text { get; set; }
        public ICollection<LanguageTag> Languages { get; set; } = [];
        public string? SysNotes { get; set; } // Internal notes about this tag
    }
}
