CREATE TABLE Driver (
    DriverId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(64) NOT NULL,
    LastName NVARCHAR(64) NOT NULL,
    Phone NVARCHAR(32) NULL,
    Email NVARCHAR(128) NULL,
    LicenseNumber NVARCHAR(64) NULL,
    DriverState NVARCHAR(32) NULL, -- Ej: Active, Inactive, Suspended
    Notes NVARCHAR(256) NULL
);
