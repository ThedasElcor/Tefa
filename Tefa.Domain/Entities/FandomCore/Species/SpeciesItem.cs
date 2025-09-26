using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.MetadataCore.Ao3Tags;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Species
{
    public class SpeciesItem
    {
        // NOTE: A Species entity represents a curated variant—an abstracted, semi-canonical concept like "Tolkien Elf"or "Dragon Age Elf".
        // Variants are used for organizing, tagging, and linking characters across the system.
        public required int Id { get; set; }
        public FandomId? OriginalFandomId { get; set; } //Use "Generic Fandom (1)" for non-specific species like "Human"
        public Fandom? OriginalFandom { get; set; }
        public required string Name { get; set; }
        public ICollection<SpeciesSysTag> SystemTags { get; set; } = [];

        // Navigation Properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<CharacterSpecies> Characters { get; set; } = [];
        public ICollection<Conlang> AssociatedConlangs { get; set; } = [];
        public ICollection<Event> AssoiciatedEvents { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];

        //For species with multiple variants like elves or dwarves
        public SpeciesItem? RootVariant { get; set; }
        public ICollection<SpeciesVariantLink> VariantOf { get; set; } = [];
        public ICollection<SpeciesVariantLink> Variants { get; set; } = [];
        public ICollection<SpeciesItem> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility
    }
}
