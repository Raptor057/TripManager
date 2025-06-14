using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ITripScheduleRepository
{
    /// <summary>
    /// Get all trip schedules
    /// </summary>
    /// <returns>A collection of trip schedules.</returns>
    Task<IEnumerable<TripSchedule>> GetAllTripSchedulesAsync();

    /// <summary>
    /// Get a trip schedule by its ID.
    /// </summary>
    /// <param name="tripScheduleId">The ID of the trip schedule.</param>
    /// <returns>The trip schedule if found, otherwise null.</returns>
    Task<TripSchedule?> GetTripScheduleByIdAsync(int tripScheduleId);

    /// <summary>
    /// Save a new trip schedule.
    /// </summary>
    /// <param name="tripSchedule">The trip schedule to save.</param>
    /// <returns>The saved trip schedule.</returns>
    Task<TripSchedule> SaveTripScheduleAsync(TripSchedule tripSchedule);

    /// <summary>
    /// Update an existing trip schedule.
    /// </summary>
    /// <param name="tripSchedule">The trip schedule to update.</param>
    /// <returns>The updated trip schedule.</returns>
    Task<TripSchedule> UpdateTripScheduleAsync(TripSchedule tripSchedule);
    
    /// <summary>
    /// Delete a trip schedule by its ID.
    /// </summary>
    /// <param name="tripScheduleId"></param>
    /// <returns></returns>
    Task<TripSchedule> DeleteTripScheduleAsync(int tripScheduleId);
}