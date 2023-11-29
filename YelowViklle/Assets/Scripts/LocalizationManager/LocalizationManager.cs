using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager Instance;

    public SystemLanguage language;

    public DataLocalization[] data;

    public Dictionary<SystemLanguage, Dictionary<string, string>> _translate = new Dictionary<SystemLanguage, Dictionary<string, string>>();

    private void Awake()
    {
        Instance = this;
        _translate = LanguagueU.LoadTranslate(data);
    }

    public string GetTranslate(string ID)
    {
        if (!_translate.ContainsKey(language))
        return ("no lang");

        if (!_translate[language].ContainsKey(ID))
            return "no ID";

        return _translate[language][ID];

    }
}
