using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class GroupMANote : LocalizedNote
    {
        public required int GroupMAId { get; set; }
        public required GroupMA GroupMA { get; set; }
    }
}
