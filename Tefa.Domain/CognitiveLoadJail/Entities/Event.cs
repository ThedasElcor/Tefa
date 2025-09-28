using Tefa.Domain.CognitiveLoadJail.Enums;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class Event
    {
        public required int Id { get; set; }
        public FandomId? PrimaryFandom { get; set; }
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<EventMedia> EventAppearances { get; set; } = [];
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants

        //Event Information
        public ICollection<EventName> EventNames { get; set; } = [];
        public ICollection<EventDescription> EventDescriptions { get; set; } = [];
        public ICollection<EventLocation> AssociatedLocations { get; set; } = [];
        public ICollection<CharacterEvent> AssociatedCharacters { get; set; } = [];
        public ICollection<GroupEP> AssociatedGroups { get; set; } = [];
        public ICollection<SpeciesEP> AssociatedSpecies { get; set; } = [];

        //Variant System (DAG)
        public int? RootVariantId { get; set; }
        public Event? RootVariant { get; set; }
        public ICollection<EventVariantLink> VariantOf { get; set; } = [];
        public ICollection<EventVariantLink> Variants { get; set; } = [];
        public ICollection <Event> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility

        //Fandom Appearances
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<EventInstance> EventInstances { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
