using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class Group
    {
        public required int Id { get; set; }
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants
        public ICollection<GroupName> Names { get; set; } = [];
        public ICollection<GroupNote> Notes { get; set; } = [];

        //Variant System (DAG)
        public int? RootVariantId { get; set; }
        public ICollection<GroupVariantLink> VariantOf { get; set; } = [];
        public ICollection<GroupVariantLink> Variants {  get; set; } = [];
        public ICollection<Group> ConfirmedDistinctFrom { get; set; } = [];  //For uniqueness verification utility

        //Navigation Properties
        public ICollection<CharacterGroup> AssociatedCharacters { get; set; } = [];
        public ICollection<GroupLanguage> AssociatedConlangs { get; set; } = [];
        public ICollection<GroupEP> AssociatedEvents { get; set; } = [];
        public ICollection<GroupLA> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesGroup> AssociatedSpecies { get; set; } = [];

        public ICollection<GroupMedia> MediaAppearances { get; set; } = [];

        //Fandom Appearances
        public ICollection<Ao3Tag> Ao3Tags { get; set;} = []; //TODO: figure out ifd this nav tag would work as expected as designed
        public ICollection<GroupInst> GroupInstances { get; set; } = [];
        public ICollection<FanWork> FanWork { get; set; } = [];
    }
}
