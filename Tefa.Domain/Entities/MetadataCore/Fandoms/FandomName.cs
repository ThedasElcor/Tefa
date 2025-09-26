using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.MetadataCore.Fandoms
{
    public class FandomName : LocalizedName
    {
        public required FandomId FandomId { get; set; }
        public required Fandom Fandom { get; set; }
    }
}
