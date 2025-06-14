CREATE TABLE LocationDestination (
    LocationDestinationId INT PRIMARY KEY IDENTITY(1,1),
    NameDestination NVARCHAR(128) NOT NULL,
    Photo VARBINARY(MAX) NULL,
    AddressDestination NVARCHAR(256) NULL,
    CityDestination NVARCHAR(128) NULL,
    StateDestination NVARCHAR(64) NULL,
    CountryDestination NVARCHAR(64) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
    )
