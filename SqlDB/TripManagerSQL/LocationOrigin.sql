CREATE TABLE LocationOrigin (
    LocationOriginId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(128) NOT NULL,
    Address NVARCHAR(256) NULL,
    City NVARCHAR(128) NULL,
    State NVARCHAR(64) NULL,
    Country NVARCHAR(64) NULL
);
