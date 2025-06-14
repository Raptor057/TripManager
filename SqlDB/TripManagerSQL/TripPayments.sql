CREATE TABLE TripPayments (
    TripPaymentId INT PRIMARY KEY IDENTITY(1,1),
    TripScheduleId INT NOT NULL REFERENCES TripSchedule(TripScheduleId),
    PassengerId INT NULL REFERENCES Passenger(PassengerId), -- NULL si es carga
    PaymentDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Amount DECIMAL(10,2) NOT NULL,
    PaymentMethod NVARCHAR(50), -- Ej: 'Cash', 'Card', 'Transfer'
    Reference NVARCHAR(100) NULL DEFAULT UPPER(NEWID()), -- Folio, ticket, etc.
    IsConfirmed BIT NOT NULL DEFAULT 1,
    Notes NVARCHAR(256) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
