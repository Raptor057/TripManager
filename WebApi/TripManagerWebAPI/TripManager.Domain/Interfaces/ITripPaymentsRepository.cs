using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ITripPaymentsRepository
{
    /// <summary>
    /// Get all trip payments
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<TripPayments>> GetAllTripPaymentsAsync();

    /// <summary>
    /// Get trip payment by Id
    /// </summary>
    /// <param name="tripPaymentId"></param>
    /// <returns></returns>
    Task<TripPayments?> GetTripPaymentByIdAsync(int tripPaymentId);

    /// <summary>
    /// Save a trip payment
    /// </summary>
    /// <param name="tripPayment"></param>
    /// <returns>The updated <see cref="TripPayments"/> entity.</returns>
    Task<TripPayments> SaveTripPaymentAsync(TripPayments tripPayment);

    /// <summary>
    /// Update a trip payment
    /// </summary>
    /// <param name="tripPayment"></param>
    /// <returns>The updated <see cref="TripPayments"/> entity.</returns>
    Task<TripPayments> UpdateTripPaymentAsync(TripPayments tripPayment);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tripPayment"></param>
    /// <returns></returns>
    Task<TripPayments> DeleteTripPaymentAsync(TripPayments tripPayment);
}