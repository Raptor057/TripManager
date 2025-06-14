using TripManager.Domain.Entities.UTCDateTime;

namespace TripManager.Domain.Interfaces.UTCDateTime;

public interface ISavedGlobalSettingsRepository
{

    /// <summary>
    /// Get all saved global settings
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<SavedGlobalSettings> GetSavedGlobalSettingsByIdAsync(int id);
    
    /// <summary>
    /// Get all saved global settings
    /// </summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    Task<SavedGlobalSettings> SaveGlobalSettingsAsync(SavedGlobalSettings settings);
    
    /// <summary>
    /// Update existing global settings
    /// </summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    Task<SavedGlobalSettings> UpdateGlobalSettingsAsync(SavedGlobalSettings settings);
}