namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum CharacterPortrayalType
    {
        Undefined = 0,
        Other = 1,

        Actor = 2,               // Full dramatic performance (live-action)
        AnimalActor = 3,         // Trained animal portraying a character
        DiegeticPerformer = 4,   // Character is treated as a real-world performer within the narrative or culture (e.g. Miss Piggy, Mickey Mouse)
        DigitalDouble = 5,       // CGI or AI-generated replication of a performer
        Figurine = 6,            // Action figures, claymation rigs, miniatures
        Model = 7,               // A person whose visual likeness used in media
        MotionCapture = 8,       // Physical performance captured digitally
        Narrator = 9,            // Storytelling voice, not tied to character
        PhysicalPerformer = 10,  // Non-speaking embodiment (e.g., wrestlers, dancers, figure skater, person in a mascot costume)
        Puppeteer = 11,          // Manipulates puppet to portray character
        Shadowcast = 12,         // Live fan performance synced to original media
        SingingVoice = 13,       // Musical vocals distinct from speaking voice
        StuntPerformer = 14,     // Action sequences and physical stunts
        SymbolicEmbodiment = 15, // Non-performer physical object or construct that portrays a character (e.g., animatronic, effigy, ritual figure)
        VoiceActor = 16          // Spoken voice performance
    }
}

