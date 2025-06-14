using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface IPassengerRepository
{
    /// <summary>
    /// Get all passengers
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Passenger>> GetAllPassengersAsync();

    /// <summary>
    /// Get passenger by Id
    /// </summary>
    /// <param name="passengerId"></param>
    /// <returns></returns>
    Task<Passenger?> GetPassengerByIdAsync(int passengerId);

    /// <summary>
    /// Save a passenger
    /// </summary>
    /// <param name="passenger"></param>
    /// <returns>The updated <see cref="Passenger"/> entity.</returns>
    Task<Passenger> SavePassengerAsync(Passenger passenger);

    /// <summary>
    /// Update a passenger
    /// </summary>
    /// <param name="passenger"></param>
    /// <returns>The updated <see cref="Passenger"/> entity.</returns>
    Task<Passenger> UpdatePassengerAsync(Passenger passenger);
    
    /// <summary>
    /// Delete a passenger
    /// </summary>
    /// <param name="passenger"></param>
    /// <returns></returns>
    Task DeletePassengerAsync(Passenger passenger);
    
}