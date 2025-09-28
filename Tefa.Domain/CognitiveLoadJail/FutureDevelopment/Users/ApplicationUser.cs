using Microsoft.AspNetCore.Identity;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Users
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Link> Links { get; set; } = [];
        public ICollection<Creator> ConnectedCreators { get; set; } = [];
        public string? SysNotes { get; set; } 
    }
}
