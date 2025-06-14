using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ITruckInterface
{
    /// <summary>
    /// Get all trucks
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Truck>> GetAllTrucksAsync();

    /// <summary>
    /// Get truck by Id
    /// </summary>
    /// <param name="truckId"></param>
    /// <returns></returns>
    Task<Truck?> GetTruckByIdAsync(int truckId);

    /// <summary>
    /// Save a truck
    /// </summary>
    /// <param name="truck"></param>
    /// <returns>The updated <see cref="Truck"/> entity.</returns>
    Task<Truck> SaveTruckAsync(Truck truck);

    /// <summary>
    /// Update a truck
    /// </summary>
    /// <param name="truck"></param>
    /// <returns>The updated <see cref="Truck"/> entity.</returns>
    Task<Truck> UpdateTruckAsync(Truck truck);
    
    /// <summary>
    /// Delete a truck by Id
    /// </summary>
    /// <param name="truckId"></param>
    /// <returns></returns>
    Task<Truck> DeleteTruckAsync(int truckId);
}