using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities
{
    public class Event
    {
        public required int Id { get; set; }
        public Fandom? PrimaryFandom { get; set; }
        public ICollection<FandomTag> Fandoms { get; set; } = [];
        public ICollection<EventMedia> EventAppearances { get; set; } = [];
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants

        //Event Information
        public ICollection<EventName> EventNames { get; set; } = [];
        public ICollection<EventNote> Notes { get; set; } = [];
        public ICollection<EventLocation> Locations { get; set; } = [];
        public ICollection<CharacterEvent> Characters { get; set; } = [];
        public ICollection<GroupEvent> Groups { get; set; } = [];
        public ICollection<SpeciesEvent> Species { get; set; } = [];

        //Variant System (DAG)
        public int? RootVariantId { get; set; }
        public Event? RootVariant { get; set; }
        public ICollection<EventVariantLink> VariantOf { get; set; } = [];
        public ICollection<EventVariantLink> Variants { get; set; } = [];
        public ICollection <Event> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility

        //Fandom Appearances
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<EventInst> Instances { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
