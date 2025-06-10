CREATE TABLE CargoItem (
    CargoItemId INT PRIMARY KEY IDENTITY,
    TripScheduleId INT NOT NULL REFERENCES TripSchedule(TripScheduleId),
    Description NVARCHAR(256) NOT NULL,
    WeightKg DECIMAL(10,2) NULL,
    VolumeM3 DECIMAL(10,2) NULL,
    Quantity INT NULL,
    CargoItemState NVARCHAR(32) NULL -- Ej: Loaded, InTransit, Delivered
);
