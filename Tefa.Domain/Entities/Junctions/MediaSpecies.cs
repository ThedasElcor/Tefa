using Tefa.Domain.Entities.Media;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Entities.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class MediaSpecies
    {
        public required int Id { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media { get; set; }
        public required int SpeciedId { get; set; }
        public required SpeciesItem Species {  get; set; }
        public required EntityAppearanceType EntityAppearanceType { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];

    }
}
