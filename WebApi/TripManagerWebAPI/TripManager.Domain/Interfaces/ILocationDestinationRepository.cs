using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ILocationDestinationRepository
{
    /// <summary>
    /// Get all location destinations
    /// </summary>
    /// <returns>List of location destinations</returns>
    Task<IEnumerable<LocationDestination>> GetAllLocationDestinationsAsync();

    /// <summary>
    /// Get location destination by Id
    /// </summary>
    /// <param name="locationDestinationId">Location destination Id</param>
    /// <returns>Location destination entity</returns>
    Task<LocationDestination?> GetLocationDestinationByIdAsync(int locationDestinationId);

    /// <summary>
    /// Save a location destination
    /// </summary>
    /// <param name="locationDestination">Location destination entity</param>
    /// <returns>The saved location destination entity</returns>
    Task<LocationDestination> SaveLocationDestinationAsync(LocationDestination locationDestination);

    /// <summary>
    /// Update a location destination
    /// </summary>
    /// <param name="locationDestination">Location destination entity</param>
    /// <returns>The updated location destination entity</returns>
    Task<LocationDestination> UpdateLocationDestinationAsync(LocationDestination locationDestination);

    /// <summary>
    /// Delete a location destination
    /// </summary>
    /// <param name="locationDestination">Location destination entity to delete</param>
    Task DeleteLocationDestinationAsync(LocationDestination locationDestination);
    
}