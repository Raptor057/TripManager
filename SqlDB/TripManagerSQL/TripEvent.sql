CREATE TABLE TripEvent (
    TripEventId INT PRIMARY KEY IDENTITY(1,1),
    TripScheduleId INT NOT NULL REFERENCES TripSchedule(TripScheduleId),
    EventDateTime DATETIME NOT NULL DEFAULT GETDATE(),
    EventDescription NVARCHAR(512) NOT NULL,
    EventType NVARCHAR(32) NULL, -- Ej: CheckIn, Break, Issue, Delivery, etc.
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
