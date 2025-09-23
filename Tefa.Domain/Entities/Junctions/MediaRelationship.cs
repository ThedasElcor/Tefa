
using Tefa.Domain.Entities.Media;
using Tefa.Domain.Entities.Relationships;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class MediaRelationship
    {
        public required int Id { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
        public required int RelationshipId { get; set; }
        public required Relationship Relationship { get; set; }
        public required EntityAppearanceType AppearanceType { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
