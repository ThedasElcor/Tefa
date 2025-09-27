using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.MetadataCore.Media;
using Tefa.Domain.Enums.Media;

namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class SpeciesMA
    {
        public required int Id { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media { get; set; }
        public required int SpeciedId { get; set; }
        public required SpeciesItem Species {  get; set; }
        public required EntityAppearanceType EntityAppearanceType { get; set; }
        public ICollection<SpeciesMANote> NuanceNotes { get; set; } = [];

    }
}
