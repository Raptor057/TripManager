using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ITripPassengersRepository
{
    /// <summary>
    /// Get all passengers for a specific trip schedule.
    /// </summary>
    /// <param name="tripScheduleId">The ID of the trip schedule.</param>
    /// <returns>A list of trip passengers.</returns>
    Task<IEnumerable<TripPassengers>> GetPassengersByTripScheduleIdAsync(int tripScheduleId);
    
    /// <summary>
    /// Add a new passenger to a trip schedule.
    /// </summary>
    /// <param name="passenger">The passenger to add.</param>
    /// <returns>The added passenger.</returns>
    Task<TripPassengers> AddPassengerAsync(TripPassengers passenger);

    /// <summary>
    /// Update an existing passenger's details.
    /// </summary>
    /// <param name="passenger">The passenger with updated details.</param>
    /// <returns>The updated passenger.</returns>
    Task<TripPassengers> UpdatePassengerAsync(TripPassengers passenger);

    /// <summary>
    /// Delete a passenger from a trip schedule.
    /// </summary>
    /// <param name="tripPassengerId">The ID of the trip passenger to delete.</param>
    Task DeletePassengerAsync(int tripPassengerId);
    
    /// <summary>
    /// Delete a passenger by Id
    /// </summary>
    /// <param name="tripPassengerId"></param>
    /// <returns></returns>
    Task<TripPassengers> DeletePassengerByIdAsync(int tripPassengerId);
}