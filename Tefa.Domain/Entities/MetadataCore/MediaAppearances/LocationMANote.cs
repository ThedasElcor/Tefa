namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class LocationMANote
    {
        public required int LocationMAId { get; set; }
        public required LocationMA  LocationMA { get; set; }
    }
}
