using TripManager.Domain.Entities.Configuration;

namespace TripManager.Domain.Interfaces;

public interface IRolesRepository
{
    Task<IEnumerable<Roles>> GetAllRolesAsync();
    
}