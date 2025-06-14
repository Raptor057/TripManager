CREATE TABLE TripExpenses (
    TripExpenseId INT PRIMARY KEY IDENTITY(1,1),
    TripScheduleId INT NOT NULL REFERENCES TripSchedule(TripScheduleId),
    ExpenseType NVARCHAR(50) NOT NULL, -- Ej: Diesel, Toll, Food
    Amount DECIMAL(10,2) NOT NULL,
    Description NVARCHAR(256) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE()
);
