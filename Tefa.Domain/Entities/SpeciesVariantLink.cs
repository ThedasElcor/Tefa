namespace Tefa.Domain.Entities
{
    public class SpeciesVariantLink
    {
        public int GeneralCharacterId { get; set; }
        public required Species GeneralSpecies { get; set; }
        public int SpecificCharacterId { get; set; }
        public required Species SpecificSpecies { get; set; }
        public string? SysNotes { get; set; }
    }
}
