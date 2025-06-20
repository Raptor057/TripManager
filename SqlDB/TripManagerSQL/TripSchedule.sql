CREATE TABLE TripSchedule (
    TripScheduleId INT PRIMARY KEY IDENTITY(1,1),
    LocationOriginId INT NOT NULL REFERENCES LocationOrigin(LocationOriginId),
    LocationDestinationId INT NOT NULL REFERENCES LocationDestination(LocationDestinationId),
    TruckId INT NOT NULL REFERENCES Truck(TruckId),
    DriverId INT NOT NULL REFERENCES Driver(DriverId),
    ScheduledDeparture DATETIME NOT NULL,
    ScheduledArrival DATETIME NULL,
    ActualDeparture DATETIME NULL,
    ActualArrival DATETIME NULL,
    TripScheduleState NVARCHAR(32) NULL, -- Ej: Scheduled, InTransit, Completed, Cancelled
    Notes NVARCHAR(256) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
