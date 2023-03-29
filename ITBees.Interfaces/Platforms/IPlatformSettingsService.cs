using System.Collections.Generic;
using ITBees.Models.EmailAccounts;

namespace ITBees.Interfaces.Platforms
{
    public interface IPlatformSettingsService
    {
        List<string> GetPlatformDebugEmails();
        Environment GetCurrentEnvironment();
        EmailAccount GetPlatformDefaultEmailAccount();
        public string GetSetting(string key);
    }
}