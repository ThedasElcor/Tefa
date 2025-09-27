/* NOTE:
* IDs starting with 5 are reserved for Subfandoms.
* Subfandoms represent distinct branches within a larger fandom, typically marked by a continuity break or separate fan communities.
* For example:
*   - Mass Effect Trilogy and Mass Effect Andromeda are Subfandoms due to narrative divergence and distinct fanbases.
*   - Mass Effect (Video Game) and Mass Effect Andromeda: Initiation (Book) are Media within those Subfandoms.
* In contrast, Dragon Age — despite multiple games — is treated as a single fandom due to its continuous narrative and (generally) unified fanbase.
*/
namespace Tefa.Domain.Enums
{
    public enum FandomId
    {
        Undefined = 0, //Default for errors or unsupported crossovers (temp)
        IRL = 1, // For real-world, commonly shared entities (e.g. real cities, human species origin)
        RPF = 5, // Real People Fiction, treated like subfandom of generic

        BaldursGate = 8,
        BBCMerlin = 6,
        CriticalRole = 10,
        DragonAge = 4,
        TheElderScrolls = 9,
        MassEffect = 2,
        MassEffectTrilogy = 50,
        MassEffectAndromeda = 51,
        TheOuterWorlds = 12,
        Overwatch = 3,
        Pokemon = 13,
        Stargate = 15,
        StarTrek = 14,
        StarWars = 11,
        TheWitcher = 7,
    }
}
