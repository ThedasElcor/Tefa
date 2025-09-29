using Tefa.Domain.Entities.Tags;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities
{
    public class Ao3TagEntity
    {
        public required int Id { get; set; }
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Ao3TagTypeTag> TagTypes { get; set; } = [];
        public Status DefinitionStatus { get; set; } = Status.Pending;
        public string? SysNotes { get; set; } // Internal notes about this tag

        // Related Tags
        public ICollection<AdaptiveAidAcessibilityTag> AdaptiveAidAcessibilityTags { get; set; } = [];
        public ICollection<AdaptiveAidFunctionTag> AdaptiveAidFunctionTags { get; set; } = [];
        public ICollection<AdaptiveAidModalityTag> AdaptiveAidModalityTags { get; set; } = [];
        public ICollection<AdaptiveAidTypeTag> AdaptiveAidTypeTags { get; set; } = [];
        public ICollection<AttractionTag> AttractionTags { get; set; } = [];
        public ICollection<CommunicationTypeTag> CommunicationTypeTags { get; set; } = [];
        public ICollection<FandomTag> FandomTags { get; set; } = [];
        public ICollection<FunctionalLimitationSourceTag> FunctionalLimitationSourceTags { get; set; } = [];
        public ICollection<FunctionalLimitationTag> FunctionalLimitationTags { get; set; } = [];
        public ICollection<GenderIdentityTag> GenderIdentityTags { get; set; } = [];
        public ICollection<GenderPresentationTag> GenderPresentationTags { get; set; } = [];
        public ICollection<RelationshipStructureTag> RelationshipStructureTags { get; set; } = [];
        public ICollection<RomanticOrientationTag> RomanticOrientationTags { get; set; } = [];
        public ICollection<SexAnatomyTag> SexAnatomyTags { get; set; } = [];
        public ICollection<SexualOrientationTag> SexualOrientationTags { get; set; } = [];

        // Related Entities
        public ICollection<AdaptiveAid> AdaptiveAids { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<Condition> Conditions { get; set; } = [];
        public ICollection<Conlang> Conlangs { get; set; } = [];
        public ICollection<Event> Events { get; set; } = [];
        public ICollection<Group> Groups { get; set; } = [];
        public ICollection<Location> Locations { get; set; } = [];
        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Relationship> Relationships { get; set; } = [];
        public ICollection<Species> Species { get; set; } = [];
    }
}
