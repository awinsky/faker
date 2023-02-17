using Faker.Model;

namespace Faker.Services;

public interface ILocaleSource
{
    List<LocaleDto> GetLocales();
}

public class LocaleSource : ILocaleSource
{
    private readonly List<LocaleDto> _locales = new List<LocaleDto>
    {
        new ("af_ZA","Afrikaans"),
        new ("ar","Arabic"),
        new ("az","Azerbaijani"),
        new ("cz","Czech"),
        new ("de","German"),
        new ("de_AT","German (Austria)"),
        new ("de_CH","German (Switzerland)"),
        new ("el","Greek"),
        new ("en","English"),
        new ("en_AU","English (Australia)"),
        new ("en_AU_ocker","English (Australia Ocker)"),
        new ("en_BORK","English (Bork)"),
        new ("en_CA","English (Canada)"),
        new ("en_GB","English (Great Britain)"),
        new ("en_IE","English (Ireland)"),
        new ("en_IND","English (India)"),
        new ("en_NG","Nigeria (English)"),
        new ("en_US","English (United States)"),
        new ("en_ZA","English (South Africa)"),
        new ("es","Spanish"),
        new ("es_MX","Spanish (Mexico)"),
        new ("fa","Farsi"),
        new ("fi","Finnish"),
        new ("fr","French"),
        new ("fr_CA","French (Canada)"),
        new ("fr_CH","French (Switzerland)"),
        new ("ge","Georgian"),
        new ("hr","Hrvatski"),
        new ("id_ID","Indonesia"),
        new ("it","Italian"),
        new ("ja","Japanese"),
        new ("ko","Korean"),
        new ("lv","Latvian"),
        new ("nb_NO","Norwegian"),
        new ("ne","Nepalese"),
        new ("nl","Dutch"),
        new ("nl_BE","Dutch (Belgium)"),
        new ("pl","Polish"),
        new ("pt_BR","Portuguese (Brazil)"),
        new ("pt_PT","Portuguese (Portugal)"),
        new ("ro","Romanian"),
        new ("ru","Russian"),
        new ("sk","Slovakian"),
        new ("sv","Swedish"),
        new ("tr","Turkish"),
        new ("uk","Ukrainian"),
        new ("vi","Vietnamese"),
        new ("zh_CN","Chinese"),
        new ("zh_TW","Chinese (Taiwan)"),
        new ("zu_ZA","Zulu (South Africa)"),

    };

    public List<LocaleDto> GetLocales()
    {
        return _locales;
    }
}