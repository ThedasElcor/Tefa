using System.ComponentModel.DataAnnotations;
using Tefa.Domain.Attributes;

namespace Tefa.Domain.Enums.Language
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum Language
    {
        [Display(Name = "Undefined")]
        [IsoCode("und")]
        Undefined = 1,

        [Display(Name = "Afrikaans")]
        [IsoCode("af")]
        Afrikaans = 2,

        [Display(Name = "አማርኛ")]
        [IsoCode("am")]
        Amharic = 3,

        [Display(Name = "العربية")]
        [IsoCode("ar")]
        Arabic = 4,

        [Display(Name = "Azərbaycan dili")]
        [IsoCode("az")]
        Azerbaijani = 5,

        [Display(Name = "Беларуская")]
        [IsoCode("be")]
        Belarusian = 6,

        [Display(Name = "Български")]
        [IsoCode("bg")]
        Bulgarian = 7,

        [Display(Name = "বাংলা")]
        [IsoCode("bn")]
        Bengali = 8,

        [Display(Name = "Català")]
        [IsoCode("ca")]
        Catalan = 9,

        [Display(Name = "Čeština")]
        [IsoCode("cs")]
        Czech = 10,

        [Display(Name = "Dansk")]
        [IsoCode("da")]
        Danish = 11,

        [Display(Name = "Deutsch")]
        [IsoCode("de")]
        German = 12,

        [Display(Name = "Ελληνικά")]
        [IsoCode("el")]
        Greek = 13,

        [Display(Name = "English")]
        [IsoCode("en")]
        English = 14,

        [Display(Name = "Español")]
        [IsoCode("es")]
        Spanish = 15,

        [Display(Name = "Eesti")]
        [IsoCode("et")]
        Estonian = 16,

        [Display(Name = "Suomi")]
        [IsoCode("fi")]
        Finnish = 17,

        [Display(Name = "Français")]
        [IsoCode("fr")]
        French = 18,

        [Display(Name = "Galego")]
        [IsoCode("gl")]
        Galician = 19,

        [Display(Name = "ગુજરાતી")]
        [IsoCode("gu")]
        Gujarati = 20,

        [Display(Name = "עברית")]
        [IsoCode("he")]
        Hebrew = 21,

        [Display(Name = "हिन्दी")]
        [IsoCode("hi")]
        Hindi = 22,

        [Display(Name = "Hrvatski")]
        [IsoCode("hr")]
        Croatian = 23,

        [Display(Name = "Magyar")]
        [IsoCode("hu")]
        Hungarian = 24,

        [Display(Name = "Հայերեն")]
        [IsoCode("hy")]
        Armenian = 25,

        [Display(Name = "Bahasa Indonesia")]
        [IsoCode("id")]
        Indonesian = 26,

        [Display(Name = "Íslenska")]
        [IsoCode("is")]
        Icelandic = 27,

        [Display(Name = "Italiano")]
        [IsoCode("it")]
        Italian = 28,

        [Display(Name = "日本語")]
        [IsoCode("ja")]
        Japanese = 29,

        [Display(Name = "ქართული")]
        [IsoCode("ka")]
        Georgian = 30,

        [Display(Name = "Қазақ тілі")]
        [IsoCode("kk")]
        Kazakh = 31,

        [Display(Name = "한국어")]
        [IsoCode("ko")]
        Korean = 32,

        [Display(Name = "Кыргызча")]
        [IsoCode("ky")]
        Kyrgyz = 33,

        [Display(Name = "Lietuvių")]
        [IsoCode("lt")]
        Lithuanian = 34,

        [Display(Name = "Latviešu")]
        [IsoCode("lv")]
        Latvian = 35,

        [Display(Name = "Македонски")]
        [IsoCode("mk")]
        Macedonian = 36,

        [Display(Name = "Монгол")]
        [IsoCode("mn")]
        Mongolian = 37,

        [Display(Name = "मराठी")]
        [IsoCode("mr")]
        Marathi = 38,

        [Display(Name = "Bahasa Melayu")]
        [IsoCode("ms")]
        Malay = 39,

        [Display(Name = "Nederlands")]
        [IsoCode("nl")]
        Dutch = 40,

        [Display(Name = "Norsk")]
        [IsoCode("no")]
        Norwegian = 41,

        [Display(Name = "Polski")]
        [IsoCode("pl")]
        Polish = 42,

        [Display(Name = "Português")]
        [IsoCode("pt")]
        Portuguese = 43,

        [Display(Name = "Română")]
        [IsoCode("ro")]
        Romanian = 44,

        [Display(Name = "Русский")]
        [IsoCode("ru")]
        Russian = 45,

        [Display(Name = "සිංහල")]
        [IsoCode("si")]
        Sinhala = 46,

        [Display(Name = "Slovenčina")]
        [IsoCode("sk")]
        Slovak = 47,

        [Display(Name = "Slovenščina")]
        [IsoCode("sl")]
        Slovenian = 48,

        [Display(Name = "Српски")]
        [IsoCode("sr")]
        Serbian = 49,

        [Display(Name = "Svenska")]
        [IsoCode("sv")]
        Swedish = 50,

        [Display(Name = "தமிழ்")]
        [IsoCode("ta")]
        Tamil = 51,

        [Display(Name = "తెలుగు")]
        [IsoCode("te")]
        Telugu = 52,

        [Display(Name = "ไทย")]
        [IsoCode("th")]
        Thai = 53,

        [Display(Name = "Türkçe")]
        [IsoCode("tr")]
        Turkish = 54,

        [Display(Name = "Українська")]
        [IsoCode("uk")]
        Ukrainian = 55,

        [Display(Name = "اردو")]
        [IsoCode("ur")]
        Urdu = 56,

        [Display(Name = "O‘zbek")]
        [IsoCode("uz")]
        Uzbek = 57,

        [Display(Name = "Tiếng Việt")]
        [IsoCode("vi")]
        Vietnamese = 58,

        [Display(Name = "中文")]
        [IsoCode("zh")]
        Chinese = 59
    }
}
