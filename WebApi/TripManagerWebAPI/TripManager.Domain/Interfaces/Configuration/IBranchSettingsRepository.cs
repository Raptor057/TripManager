using TripManager.Domain.Entities.Configuration;

namespace TripManager.Domain.Interfaces;

public interface IBranchSettingsRepository
{
    /// <summary>
    /// Get branch settings by branch Id
    /// </summary>
    /// <param name="branchId"></param>
    /// <returns></returns>
    Task<BranchSettings> GetBranchSettingsByIdAsync(int branchId);
    
    /// <summary>
    /// Get all branch settings
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<BranchSettings>> GetAllBranchSettingsAsync();
    
    /// <summary>
    /// Add new branch settings
    /// </summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    Task AddBranchSettingsAsync(BranchSettings settings);
    
    /// <summary>
    /// Update existing branch settings
    /// </summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    Task UpdateBranchSettingsAsync(BranchSettings settings);
    
    /// <summary>
    /// Delete branch settings by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteBranchSettingsAsync(int id);
}