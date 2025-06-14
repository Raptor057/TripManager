CREATE TABLE LocationDestination (
    LocationDestinationId INT PRIMARY KEY IDENTITY(1,1),
    NameDestination NVARCHAR(128) NOT NULL,
    AddressDestination NVARCHAR(256) NULL,
    CityDestination NVARCHAR(128) NULL,
    StateDestination NVARCHAR(64) NULL,
    CountryDestination NVARCHAR(64) NULL
);
