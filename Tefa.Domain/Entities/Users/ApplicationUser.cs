using Microsoft.AspNetCore.Identity;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Users
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Link> Links { get; set; } = [];
        public ICollection<Creator> ConnectedCreators { get; set; } = [];
        public string? SysNotes { get; set; } 
    }
}
