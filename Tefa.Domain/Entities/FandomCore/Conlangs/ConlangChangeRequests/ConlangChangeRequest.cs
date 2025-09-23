using Tefa.Domain.Entities.FandomCore.Characters.CharacterChangeRequest;
using Tefa.Domain.Entities.FandomCore.ConLangs;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Conlangs.ConlangChangeRequest
{
    public class ConLangChangeRequest
    {
        public required int Id { get; set; }
        // Change Request Metadata
        public ConLang? ExistingLanguage { get; set; }
        public required string UserRequested {  get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public int? ReviewLogId { get; set; }
        public CharacterChangeReviewLog? ReviewLog { get; set; }

        // Change Request Content
        public string FreeformNotes { get; set; } = string.Empty;
        public ICollection<ConLangName> Names { get; set; } = [];
        public FandomId? OriginalFandom { get; set; }
        public ICollection<Fandom> Fandoms { get; set; } = [];
    }
}
