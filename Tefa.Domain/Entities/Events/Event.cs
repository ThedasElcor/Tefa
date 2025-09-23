using Tefa.Domain.Entities.Ao3Tags;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Fandoms;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Events
{
    /// <summary>
    /// Represents an event, or a possible event variant in the system.
    /// </summary>
    /// <remarks>
    /// This is for fictional events (or historical events if the fandom is historical ficiton),
    /// NOT for "community events" being run on the website.
    /// For a more in depth explanation of hte distinction between varaint and instance, 
    /// please see the Character Entity.
    /// </remarks>
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
        public ICollection<EventGroup> AssociatedGroups { get; set; } = [];
        public ICollection<EventSpecies> AssociatedSpecies { get; set; } = [];

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
