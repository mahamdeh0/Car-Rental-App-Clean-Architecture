namespace CarRentalApp.Application.InterfacesService
{
    public interface IAuthService
    {
        Task<string> AuthenticateAsync(string email, string password);
    }
}
