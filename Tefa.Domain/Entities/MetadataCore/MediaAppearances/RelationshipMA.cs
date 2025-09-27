using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Entities.MetadataCore.Media;
using Tefa.Domain.Enums.Media;

namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class RelationshipMA
    {
        public required int Id { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
        public required int RelationshipId { get; set; }
        public required Relationship Relationship { get; set; }
        public required EntityAppearanceType AppearanceType { get; set; }
        public ICollection<RelationshipMANote> Notes { get; set; } = [];
    }
}
