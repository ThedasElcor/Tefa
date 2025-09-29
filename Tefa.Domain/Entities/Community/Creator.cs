using Tefa.Domain.Entities.Users;

namespace Tefa.Domain.Entities.Community
{
    public class Creator
    {
        //Creator entity for archiving
        //To preserve privacy, this will be an id and notes only
        //Except when the creator is also a user of the system, in which case we can link to that user account
        public required int Id { get; set; }
        protected string? SysNotes { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
