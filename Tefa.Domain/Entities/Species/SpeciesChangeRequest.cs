using Tefa.Domain.Entities.Ao3Connections;
using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Species
{
    public class SpeciesChangeRequest
    {
        public required int Id { get; set; }
        // Change Request Metadata
        public SpeciesItem? ExistingSpecies {  get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public SpeciesChangeReviewLog? ReviewLog { get; set; }

        //Change Request Content
        public string FreeformNotes { get; set; } = string.Empty;
        public FandomId? OriginalFandomId { get; set; } //Use "Generic Fandom (1)" for non-specific species like "Human"
        public Fandom? OriginalFandom { get; set; }
        public required string Name { get; set; }
        public ICollection<SpeciesSysTag> SystemTags { get; set; } = [];

        // Navigation Properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];

        //For species with multiple variants like elves or dwarves
        public SpeciesItem? RootVariant { get; set; }
        public ICollection<SpeciesVariantLink> VariantOf { get; set; } = [];
        public ICollection<SpeciesVariantLink> Variants { get; set; } = [];
        public ICollection<SpeciesItem> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility
    }
}
