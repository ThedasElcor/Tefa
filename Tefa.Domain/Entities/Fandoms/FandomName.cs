using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Fandoms
{
    public class FandomName
    {
        public required int Id { get; set; }
        public required string Lang { get; set; } // ISO standardized language code
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required FandomId FandomId { get; set; }
        public required Fandom Fandom { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
