namespace Tefa.Domain.Entities
{
    public class ConlangVariantLink
    {
        public required int GeneralConlangId { get; set; }
        public required Conlang GeneralConlang { get; set; }
        public required int SpecificConlangId { get; set; }
        public required Conlang SpecificConlang { get; set; }
        public string? SysNotes { get; set; }
    }
}
