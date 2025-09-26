using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class SpeciesMANote : LocalizedNote
    {
        public required int SpeciesMAId { get; set; }
        public required SpeciesMA SpeciesMA { get; set; }
    }
}
