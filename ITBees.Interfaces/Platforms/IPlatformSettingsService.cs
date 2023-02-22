using System.Collections.Generic;

namespace ITBees.Interfaces.Platforms
{
    public interface IPlatformSettingsService
    {
        List<string> GetPlatformDebugEmails();
        Environment GetCurrentEnvironment();
    }

    public enum Environment
    {
        Dev,
        Uat,
        Prod
    }
}