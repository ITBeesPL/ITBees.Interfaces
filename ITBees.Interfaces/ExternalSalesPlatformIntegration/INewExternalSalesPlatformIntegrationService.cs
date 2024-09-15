using System.Threading.Tasks;
using ITBees.Interfaces.ExternalSalesPlatformIntegration.Models;

namespace ITBees.Interfaces.ExternalSalesPlatformIntegration;

public interface INewExternalSalesPlatformIntegrationService
{
    Task<NewLeadCreateResultVm> Create(NewLeadIm new1LeadIm);
}