namespace Tefa.Domain.Entities.FandomCore.Characters
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
