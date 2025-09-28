using Tefa.Domain.CognitiveLoadJail.Enums;
using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class FandomMedia
    {
        public required int Id { get; set; }
        public required FandomId FandomId { get; set; }
        public required Fandom Fandom {  get; set; }
        public required int MediaId { get; set; }
        public required Media Media {  get; set; }
        public ICollection<FandomMediaNote> Notes { get; set; } = [];
    }
}
