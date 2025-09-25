using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.MetadataCore.Fandoms;

namespace Tefa.Domain.Entities.Shared
{
    public abstract class Instance
    {
        public required int Id { get; set; }
        public ICollection<LanguageTag> LanguageTags { get; set; } = []; // What language(s) is this instance written in
        public int? FanWorkId {  get; set; }
        public FanWork? FanWork { get; set; } // Null for offers/requests, required for searchable entries
        public ICollection<Fandom> InstanceFandoms { get; set; } = []; //Defaults and crossover additions

        public string? InstanceName { get; set; }
        public bool CanonicalUse { get; set; } = true; // True if used as in canon, false if AU or altered

        public string? FreeformNotes { get; set; }
    }
}
