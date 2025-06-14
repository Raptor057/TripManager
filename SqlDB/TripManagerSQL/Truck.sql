CREATE TABLE Truck (
    TruckId INT PRIMARY KEY IDENTITY,
    LicensePlate NVARCHAR(32) NOT NULL, -- Placa / Matricula / Numero
    Model NVARCHAR(64) NULL, -- Modelo
    Brand NVARCHAR(64) NULL, -- Marca
    ManufactureYear INT NULL, -- Año
    Capacity INT NULL, -- Capacidad
    TruckState NVARCHAR(32) NULL, -- Ej: Available, Maintenance, InUse
    Notes NVARCHAR(256) NULL
);
