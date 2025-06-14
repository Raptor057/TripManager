using TripManager.Domain.Entities;

namespace TripManager.Domain.Interfaces;

public interface ITripExpensesRepository
{
    /// <summary>
    /// Get all trip expenses
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<TripExpenses>> GetAllTripExpensesAsync();

    /// <summary>
    /// Get trip expense by Id
    /// </summary>
    /// <param name="expenseId"></param>
    /// <returns></returns>
    Task<TripExpenses?> GetTripExpensesByIdAsync(int expenseId);

    /// <summary>
    /// Save a trip expense
    /// </summary>
    /// <param name="expense"></param>
    /// <returns>The updated <see cref="TripExpenses"/> entity.</returns>
    Task<TripExpenses> SaveTripExpensesAsync(TripExpenses expense);

    /// <summary>
    /// Update a trip expense
    /// </summary>
    /// <param name="expense"></param>
    /// <returns>The updated <see cref="TripExpense"/> entity.</returns>
    Task<TripExpenses> UpdateTripExpensesAsync(TripExpenses expense);
    
    /// <summary>
    /// Delete a trip expense by Id
    /// </summary>
    /// <param name="expenseId"></param>
    /// <returns></returns>
    Task<TripExpenses> DeleteTripExpensesAsync(int expenseId);
}