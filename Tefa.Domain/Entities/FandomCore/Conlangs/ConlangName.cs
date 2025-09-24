namespace Tefa.Domain.Entities.FandomCore.Conlangs
{
    public class ConlangName
    {
        public required int Id { get; set; }
        public required string Lang { get; set; } // ISO standardized language code
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
