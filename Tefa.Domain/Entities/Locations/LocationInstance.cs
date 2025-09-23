using Tefa.Domain.Entities.Community;

namespace Tefa.Domain.Entities.Locations
{
    public class LocationInstance
    {
        public required int Id { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public bool CanonicalUse { get; set; } = true; // True if used as in canon, false if AU or altered
        public string? Notes { get; set; } // e.g. "Used as a space station in sci-fi AU"
        public string? MetadataKey { get; set; }
        public string? MetadataJson { get; set; }

        public int? FanWorkId { get; set; }
        public FanWork? FanWork { get; set; }

    }
}
