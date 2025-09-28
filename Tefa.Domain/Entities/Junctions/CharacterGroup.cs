namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterGroup
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public ICollection<CharacterGroupNote> Notes { get; set; } = [];
    }
}
