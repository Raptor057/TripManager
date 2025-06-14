using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ITripEventReposiroty
{
    /// <summary>
    /// Get all trip events
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<TripEvent>> GetAllTripEventsAsync();

    /// <summary>
    /// Get trip event by Id
    /// </summary>
    /// <param name="tripEventId"></param>
    /// <returns></returns>
    Task<TripEvent?> GetTripEventByIdAsync(int tripEventId);

    /// <summary>
    /// Save a trip event
    /// </summary>
    /// <param name="tripEvent"></param>
    /// <returns>The updated <see cref="TripEvent"/> entity.</returns>
    Task<TripEvent> SaveTripEventAsync(TripEvent tripEvent);

    /// <summary>
    /// Update a trip event
    /// </summary>
    /// <param name="tripEvent"></param>
    /// <returns>The updated <see cref="TripEvent"/> entity.</returns>
    Task<TripEvent> UpdateTripEventAsync(TripEvent tripEvent);
    
    /// <summary>
    /// Delete a trip event
    /// </summary>
    /// <param name="tripEvent"></param>
    /// <returns></returns>
    Task DeleteTripEventAsync(TripEvent tripEvent);
    
}