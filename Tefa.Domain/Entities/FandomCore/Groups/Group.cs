using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.ConlangAssociations;
using Tefa.Domain.Entities.FandomCore.EventParticipants;
using Tefa.Domain.Entities.FandomCore.GroupParticipants;
using Tefa.Domain.Entities.FandomCore.LocationsAssociated;
using Tefa.Domain.Entities.MetadataCore.Ao3Tags;
using Tefa.Domain.Entities.MetadataCore.MediaAppearances;

namespace Tefa.Domain.Entities.FandomCore.Groups
{
    public class Group
    {
        public required int Id { get; set; }
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants
        public ICollection<GroupName> Names { get; set; } = [];
        public ICollection<GroupDescription> Descriptions { get; set; } = [];
        public ICollection<GroupNote> Notes { get; set; } = [];

        //Variant System (DAG)
        public int? RootVariantId { get; set; }
        public ICollection<GroupVariantLink> VariantOf { get; set; } = [];
        public ICollection<GroupVariantLink> Variants {  get; set; } = [];
        public ICollection<Group> ConfirmedDistinctFrom { get; set; } = [];  //For uniqueness verification utility

        //Navigation Properties
        public ICollection<CharacterGP> AssociatedCharacters { get; set; } = [];
        public ICollection<GroupCA> AssociatedConlangs { get; set; } = [];
        public ICollection<GroupEP> AssociatedEvents { get; set; } = [];
        public ICollection<GroupLA> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesGP> AssociatedSpecies { get; set; } = [];

        public ICollection<GroupMA> MediaAppearances { get; set; } = [];

        //Fandom Appearances
        public ICollection<Ao3Tag> Ao3Tags { get; set;} = []; //TODO: figure out ifd this nav tag would work as expected as designed
        public ICollection<GroupInstance> GroupInstances { get; set; } = [];
        public ICollection<FanWork> FanWork { get; set; } = [];
    }
}
