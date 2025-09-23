using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Events
{
    public class EventChangeRequest
    {
        public required int Id { get; set; }
        public int? ExistingEventId { get; set; }
        public Event? ExistingEvent { get; set; }
        public required string UserRequested {  get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public int? ReviewLogId { get; set; }
        public EventChangeReviewLog? ReviewLog { get; set; }

        //Change Request Content
        public EventInstance? EventInstance { get; set; } //To be compared with current canon version for complex change requests
        public string? FreeformNotes { get; set; }

    }
}
