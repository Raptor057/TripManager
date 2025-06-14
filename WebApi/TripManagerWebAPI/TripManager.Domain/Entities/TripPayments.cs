namespace TripManager.Domain.Entities;

public class TripPayments
{
    public int TripPaymentId { get; set; }

    public int TripScheduleId { get; set; }

    public int? PassengerId { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; }

    public string Reference { get; set; }

    public bool IsConfirmed { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}