CREATE TABLE Truck (
    TruckId INT PRIMARY KEY IDENTITY,
    LicensePlate NVARCHAR(32) NOT NULL,
    Model NVARCHAR(64) NULL,
    Brand NVARCHAR(64) NULL,
    ManufactureYear INT NULL,
    CapacityKg INT NULL,
    TruckState NVARCHAR(32) NULL, -- Ej: Available, Maintenance, InUse
    Notes NVARCHAR(256) NULL
);
