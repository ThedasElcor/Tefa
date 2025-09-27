using System.Resources;
using Tefa.Resources.Resources;

namespace Tefa.Resources.Extensions
{
    public static class EnumLocalizationExtensions
    {
            private static readonly ResourceManager ResourceManager = EnumResources.ResourceManager;

            public static string GetLocalizedName(this Enum value)
            {
                var key = $"{value.GetType().Name}_{value}_Name";
                return ResourceManager.GetString(key) ?? $"[[{key}]]";
            }

            public static string GetLocalizedDescription(this Enum value)
            {
                var key = $"{value.GetType().Name}_{value}_Description";
                return ResourceManager.GetString(key) ?? $"[[{key}]]";
            }
    }
}
