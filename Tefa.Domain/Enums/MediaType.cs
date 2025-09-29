namespace Tefa.Domain.Enums
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum MediaType
    {
        Unspecified = 0,
        Other = 1,

        // Written Narrative
        Novel = 2,
        Novella = 3,
        Poetry = 4,
        SerializedFiction = 5,
        ShortStory = 6,

        // Visual Narrative
        ComicBook = 7,
        ComicStrip = 8,
        GraphicNovel = 9,
        Manga = 10,
        Webcomic = 11,

        // Screen Media
        AnimatedSeries = 12,
        Movie = 13,
        ShortFilm = 14,
        TVSeries = 15,
        WebSeries = 16,

        // Audio Media
        AudioDrama = 17,
        MusicAlbum = 18,
        Podcast = 19,
        Song = 20,

        // Games
        BoardGame = 21,
        CardGame = 22,
        InteractiveFiction = 23,
        MobileGame = 24,
        TabletopRPG = 25,
        VideoGame = 26,
        WebGame = 27,

        // Performance
        Dance = 28,
        Musical = 29,
        PerformanceArt = 30,
        StagePlay = 31,

        // Experiential
        ARG = 32,
        Exhibition = 33,
        ThemePark = 34,

        // Other
        Collection = 35,
    }
}

