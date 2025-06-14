using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ILocationOriginRepository
{
    /// <summary>
    /// Get all location origins
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<LocationOrigin>> GetAllLocationOriginsAsync();

    /// <summary>
    /// Get location origin by Id
    /// </summary>
    /// <param name="locationOriginId"></param>
    /// <returns></returns>
    Task<LocationOrigin?> GetLocationOriginByIdAsync(int locationOriginId);

    /// <summary>
    /// Save a location origin
    /// </summary>
    /// <param name="locationOrigin"></param>
    /// <returns>The updated <see cref="LocationOrigin"/> entity.</returns>
    Task<LocationOrigin> SaveLocationOriginAsync(LocationOrigin locationOrigin);

    /// <summary>
    /// Update a location origin
    /// </summary>
    /// <param name="locationOrigin"></param>
    /// <returns>The updated <see cref="LocationOrigin"/> entity.</returns>
    Task<LocationOrigin> UpdateLocationOriginAsync(LocationOrigin locationOrigin);
    
    /// <summary>
    /// Delete a location origin
    /// </summary>
    /// <param name="locationOrigin"></param>
    /// <returns></returns>
    Task DeleteLocationOriginAsync(LocationOrigin locationOrigin);
    
}