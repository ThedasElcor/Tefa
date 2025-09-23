namespace Tefa.Domain.Entities.Locations
{
    public class LocationVariantLink
    {
        public int GeneralLocationId { get; set; }
        public required Location GeneralLocation { get; set; }
        public int SpecificLocationId { get; set; }
        public required Location SpecificLocation { get; set; }
        public string? SysNotes { get; set; }
    }
}
}
