using System.Collections.Generic;
using ITBees.Models.Languages;

namespace ITBees.Interfaces.Lang;

public interface ILanguageFactory
{
    void LoadData(List<Language> languages);
    Language Get(string language);
}