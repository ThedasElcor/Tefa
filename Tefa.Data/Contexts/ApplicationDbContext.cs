
using Microsoft.EntityFrameworkCore;
using Tefa.Domain.Entities;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Data.Contexts
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<AdaptiveAid> AdaptiveAids { get; set; }

        //Abstract
        public DbSet<ChangeRequest> ChangeRequests { get; set; }
        public DbSet<Instance> Instances { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<LocalizedName> LocalizedNames { get; set; }
        public DbSet<LocalizedNote> LocalizedNotes { get; set; }
    }
}

