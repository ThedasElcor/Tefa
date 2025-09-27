
using System.ComponentModel.DataAnnotations;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums.Admin;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventPrompt
    {
        public required int Id { get; set; }

        // Core prompt content
        [MaxLength(500)]
        public required string Text { get; set; }

        // Contextual linkage
        public required CommunityEventInstance FandomEventInstance { get; set; }

        // Optional entity associations
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<Relationship> Relationships { get; set; } = [];
        public ICollection<Location> Locations { get; set; } = [];
        public ICollection<Tagset> Tagsets { get; set; } = [];

        // Submitter metadata
        public string SubmittedBy { get; set; } = string.Empty; //UserName or Non-User String
        public ApplicationUser? UserSubmitted { get; set; } 
        
        // Moderation and lifecycle
        public Status Status { get; set; } = Status.Pending;
        public string? ModeratorNotes { get; set; }

        // Timestamps
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ReviewedAt { get; set; }
    }
}
