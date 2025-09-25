using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.MetadataCore.Media;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class LocationMA
    {
        public required int Id { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media { get; set; }
        public required EntityAppearanceType AppearanceType { get; set; }
        public ICollection<LocalizedNote> NuanceNotes { get; set; } = [];
    }
}
