using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface IDriverRepository
{
    /// <summary>
    /// Get all drivers
    /// </summary>
    /// <returns>List of drivers</returns>
    Task<IEnumerable<Driver>> GetAllDriversAsync();

    /// <summary>
    /// Get driver by Id
    /// </summary>
    /// <param name="driverId">Driver Id</param>
    /// <returns>Driver entity</returns>
    Task<Driver?> GetDriverByIdAsync(int driverId);

    /// <summary>
    /// Save a driver
    /// </summary>
    /// <param name="driver">Driver entity</param>
    /// <returns>The saved driver entity</returns>
    Task<Driver> SaveDriverAsync(Driver driver);

    /// <summary>
    /// Update a driver
    /// </summary>
    /// <param name="driver">Driver entity</param>
    /// <returns>The updated driver entity</returns>
    Task<Driver> UpdateDriverAsync(Driver driver);
    
    /// <summary>
    /// Delete a driver
    /// </summary>
    /// <param name="driver"></param>
    /// <returns></returns>
    Task DeleteDriverAsync(Driver driver);
    
}