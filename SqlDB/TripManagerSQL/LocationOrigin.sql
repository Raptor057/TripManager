CREATE TABLE LocationOrigin (
    LocationOriginId INT PRIMARY KEY IDENTITY(1,1),
    NameOrigin NVARCHAR(128) NOT NULL,
    Photo VARBINARY(MAX) NULL,
    AddressOrigin NVARCHAR(256) NULL,
    CityOrigin NVARCHAR(128) NULL,
    StateOrigin NVARCHAR(64) NULL,
    CountryOrigin NVARCHAR(64) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
