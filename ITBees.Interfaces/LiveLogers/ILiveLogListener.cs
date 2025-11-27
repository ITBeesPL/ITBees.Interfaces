using System.Threading.Tasks;

namespace ITBees.Interfaces.Logs;

public interface ILiveLogListener
{
    Task LogMessage(string message);
    Task LogErrorMessage(string message);
}