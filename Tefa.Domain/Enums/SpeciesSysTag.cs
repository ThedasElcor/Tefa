
namespace Tefa.Domain.Enums
{
    public enum SpeciesSysTag
    {
        Undefined = 0, // System default; indicates unfinished entry or parsing error.
        Unknown = 1,   // Identity not known or deliberately unspecified.

        Construct = 2,     // Magically or mechanically animated beings (e.g., golems, animated statues)
        Ethereal = 3,      // Non-corporeal beings (e.g., ghosts, spirits)
        HiveMind = 4,      // Collective consciousness (e.g., Borg, Zerg)
        Humanoid = 5,      // Human-like characteristics (e.g., Vulcans, Asari)
        Monstrous = 6,     // Non-anthropomorphic or monstrous (e.g., Yahg, Broodmother)
        Mythical = 7,      // Folkloric or legendary (e.g., Dragons, Unicorns)
        Synthetic = 8,     // Artificial beings (e.g., androids, robots)
        Undead = 9,        // Reanimated or undead (e.g., Vampires, Zombies)
        Godlike = 10,      // Divine or semi-divine beings (e.g., gods, avatars)
        PlantBased = 11,   // Sentient plant species (e.g., Treants, Ents)
        Fungal = 12,       // Mushroom-based species (e.g., Myconids)
        Amorphous = 13,    // Slime-based or shapeless beings (e.g., sentient goo)
        Hybrid = 14,       // Mixed-species characters (e.g., half-elf, cyborg)
        Beastfolk = 15,    // Animal-based humanoids (e.g., Khajiit, Kitsune)
        Alien = 16,        // Non-Earth origin species (e.g., Turians, Kryptonians)
        Sapient = 17       // Capable of complex thought, regardless of form
    }
}
