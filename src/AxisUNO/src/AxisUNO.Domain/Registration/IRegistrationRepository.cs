namespace AxisUNO.Domain.Registration;

public interface IRegistrationRepository
{
    Task<Registration> GetRegistrationAsync();

    Task UpdateRegistrationAsync(Registration registration);
}