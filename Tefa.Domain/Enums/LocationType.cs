
namespace Tefa.Domain.Enums
{
    public enum LocationType
    {
        Undefined = 0,
        Other = 1, // A location that does not fit into any other category; may be abstract or conceptual
        AdministrativeDivision = 2, // e.g. state, province, territory, county, district, parish, etc.
        Biome = 3, // e.g. forest, desert, tundra, grassland, etc.
        CelestialBody = 4, // e.g. planet, moon, asteroid, comet, etc.
        Continent = 5, // e.g. Africa, Asia, Europe, etc.
        Country = 6, //e.g. Nation, Vassal State, Kingdom, Empire, etc.
        Galaxy = 7, // e.g. Milky Way, Andromeda, etc.
        Landmark = 8, // e.g. mountain, river, waterfall, canyon, etc.
        MobileLocation = 9, // e.g. vehicle, ship, etc.
        OceanicBody = 10, // e.g. ocean, sea, gulf, bay, strait, etc.
        Realm = 11, // e.g. Dimension, Plane, Reality, etc.
        Region = 12, // A loosely defined geographic or thematic area (e.g., "The Outer Rim", "The North", "Pacific Northwest"); may span multiple political or physical boundaries
        Settlement = 13, // e.g. city, town, village, etc.
        SpaceStation = 14, // e.g. orbital station, deep-space station, etc.
        StarSystem = 15, // e.g. solar system, binary star system, etc.
        Structure = 16, // e.g. building, monument, bridge, etc.
        Zone = 17, // A designated area with specific function, rules, or thematic significance (e.g., "Quarantine Zone", "Neutral Zone", "Combat Zone"); may be temporary, artificial, or narrative-driven
    }
}
