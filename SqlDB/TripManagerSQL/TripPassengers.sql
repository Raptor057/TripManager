CREATE TABLE TripPassengers (
    TripPassengerId INT PRIMARY KEY IDENTITY(1,1),
    TripScheduleId INT NOT NULL REFERENCES TripSchedule(TripScheduleId),
    PassengerId INT NOT NULL REFERENCES Passenger(PassengerId),
    SeatNumber NVARCHAR(10) NULL,
    CheckInTime DATETIME NULL,
    TicketNumber NVARCHAR(50) NULL DEFAULT NEWSEQUENTIALID(),
    Notes NVARCHAR(256) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
