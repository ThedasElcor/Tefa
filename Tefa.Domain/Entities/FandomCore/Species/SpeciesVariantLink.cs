namespace Tefa.Domain.Entities.FandomCore.Species
{
    public class SpeciesVariantLink
    {
        public int GeneralCharacterId { get; set; }
        public required SpeciesItem GeneralSpecies { get; set; }
        public int SpecificCharacterId { get; set; }
        public required SpeciesItem SpecificSpecies { get; set; }
        public string? SysNotes { get; set; }
    }
}
