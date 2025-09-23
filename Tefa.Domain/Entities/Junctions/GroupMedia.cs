using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Media;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class GroupMedia
    {
        public required int Id { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
        public required EntityAppearanceType AppearanceType { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
