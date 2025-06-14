using TripManager.Domain.Entities.Configuration;

namespace TripManager.Domain.Interfaces;

public interface IBusinessInfoRepository
{
 
    /// <summary>
    /// Get business information by Id
    /// </summary>
    /// <returns></returns>
    Task<BusinessInfo> GetBusinessInfoByIdAsync();
    
    /// <summary>
    /// Get all business information
    /// </summary>
    /// <returns></returns>
    Task <BusinessInfo> GetAllBusinessInfoAsync();
    
    /// <summary>
    /// Save business information
    /// </summary>
    /// <param name="businessInfo"></param>
    /// <returns></returns>
    Task UpdateBusinessInfoAsync(BusinessInfo businessInfo);
    
    /// <summary>
    /// Add new business information
    /// </summary>
    /// <param name="businessInfo"></param>
    /// <returns></returns>
    Task AddBusinessInfoAsync(BusinessInfo businessInfo);
    
    /// <summary>
    /// Delete business information by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteBusinessInfoAsync(int id);
    
}