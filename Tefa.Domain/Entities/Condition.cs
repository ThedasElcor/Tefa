using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class Condition
    {
        public required int Id { get; set; }
        public string? SysNote { get; set; }
        public ICollection<ConditionName> ConditionNames { get; set; } = [];
        public ICollection<FunctionalLimitationTag> FunctionalLimitationTags { get; set; } = [];
        public ICollection<FunctionalLimitationSourceTag> FunctionalLimitationSourceTags { get; set; } = [];
        public ICollection<Character> CharactersAffected { get; set; } = [];
    }
}

