namespace ITBees.Interfaces.Modules
{
    /// <summary>
    /// Marker interface means the services for which we want to define access levels for individual users. For example, the UserManager.NewUserRegistrationService service should be marked as IFasModule so that it is possible to define who can create new users within the organization in other service.
    /// </summary>
    public interface IFasModule
    {
        
    }
}