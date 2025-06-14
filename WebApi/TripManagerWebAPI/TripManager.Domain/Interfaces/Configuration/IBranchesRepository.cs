using TripManager.Domain.Entities.Configuration;

namespace TripManager.Domain.Interfaces;

public interface IBranchesRepository
{
    /// <summary>
    /// Get all branches
    /// </summary>
    /// <returns></returns>
    Task <IEnumerable<Branches>> GetAllBranchesAsync();
    
    /// <summary>
    /// Get branch by Id
    /// </summary>
    /// <param name="branchId"></param>
    /// <returns></returns>
    Task<Branches?> GetBranchByIdAsync(int branchId);
    
    /// <summary>
    /// Get branch by parameters
    /// </summary>
    /// <param name="BranchName"></param>
    /// <param name="Email"></param>
    /// <param name="City"></param>
    /// <param name="State"></param>
    /// <param name="Country"></param>
    /// <returns></returns>
    Task<Branches?> GetBranchBySearchParamAsync(string? BranchName = null, string? Email = null, string? City = null, string? State = null, string? Country = null);
    
    /// <summary>
    /// Save a branch
    /// </summary>
    /// <param name="branch"></param>
    /// <returns>The updated <see cref="Branches"/> entity.</returns>
    Task<Branches> SaveBranchAsync(Branches branch);
    
    /// <summary>
    /// Update a branch
    /// </summary>
    /// <param name="branch"></param>
    /// <returns>The updated <see cref="Branches"/> entity.</returns>
    Task<Branches> UpdateBranchAsync(Branches branch);
}