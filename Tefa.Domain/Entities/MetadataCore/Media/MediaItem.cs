using Tefa.Domain.Entities.Ao3Connections;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class MediaItem
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Disambiguation { get; set; }

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> CharacterAppearances { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];
    }
}
