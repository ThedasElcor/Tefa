using Tefa.Domain.CognitiveLoadJail.Enums;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class FandomName : LocalizedName
    {
        public required FandomId FandomId { get; set; }
        public required Fandom Fandom { get; set; }
    }
}
