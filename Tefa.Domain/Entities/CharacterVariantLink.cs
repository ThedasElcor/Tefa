namespace Tefa.Domain.Entities
{
public class CharacterVariantLink
    {
            public int GeneralCharacterId { get; set; }
            public required Character GeneralCharacter { get; set; }
            public int SpecificCharacterId { get; set; }
            public required Character SpecificCharacter { get; set; }
            public string? SysNotes { get; set; }
    }
}
