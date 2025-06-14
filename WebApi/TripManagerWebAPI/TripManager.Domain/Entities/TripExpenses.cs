namespace TripManager.Domain.Entities;

public class TripExpenses
{
    public int TripExpenseId { get; set; }

    public int TripScheduleId { get; set; }

    public string ExpenseType { get; set; }

    public decimal Amount { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

}