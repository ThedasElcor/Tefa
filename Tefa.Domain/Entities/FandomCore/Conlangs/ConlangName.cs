namespace Tefa.Domain.Entities.FandomCore.ConLangs
{
    public class ConLangName
    {
        public required int Id { get; set; }
        public required string Lang { get; set; } // ISO standardized language code
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required int ConLangId { get; set; }
        public required ConLang ConLang { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
