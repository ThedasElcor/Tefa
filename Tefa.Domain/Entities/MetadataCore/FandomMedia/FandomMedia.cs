using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Entities.MetadataCore.Media;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.MetadataCore.FandomMedia
{
    public class FandomMedia
    {
        public required int Id { get; set; }
        public required FandomId FandomId { get; set; }
        public required Fandom Fandom {  get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
