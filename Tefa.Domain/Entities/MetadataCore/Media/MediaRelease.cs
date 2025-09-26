namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class MediaRelease
    {
        public required string ReleaseName { get; set; }
        public required DateTime ReleaseDate {get; set;}
        public required string ReleaseLocale { get; set;}
        public ICollection<ReleaseNote> ReleaseNotes { get; set; } = [];
    }
}
