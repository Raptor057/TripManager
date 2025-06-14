using TripManager.Domain.Entities.Configuration;

namespace TripManager.Domain.Interfaces;

public interface IUsersRepository
{
    /// <summary>
    /// Get all users
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Users>> GetAllUsersAsync();
    
    /// <summary>
    /// Get user by Id
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<Users> GetUserByIdAsync(int userId);
    
    /// <summary>
    /// Get user by search parameters
    /// </summary>
    /// <param name="username"></param>
    /// <param name="email"></param>
    /// <param name="fullName"></param>
    /// <returns></returns>
    Task<Users> GetUserBySearchParametersAsync(string? username = null, string? email = null, string? fullName = null);
    
    /// <summary>
    /// Save a user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<Users> SaveUserAsync(Users user);
    
    /// <summary>
    /// Update a user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<Users> UpdateUserAsync(Users user);
    
}