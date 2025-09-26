using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class ReleaseNote : LocalizedNote
    {
        public required int MediaReleaseId { get; set; }
        public required MediaRelease MediaRelease { get; set; }
    }
}
