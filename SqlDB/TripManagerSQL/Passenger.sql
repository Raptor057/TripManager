CREATE TABLE Passenger (
    PassengerId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(64) NOT NULL,
    LastName NVARCHAR(64) NOT NULL,
    Photo VARBINARY(MAX) NULL,
    Email NVARCHAR(128) NOT NULL,
    Phone NVARCHAR(32) NOT NULL,
    DocumentNumber NVARCHAR(64) NULL, -- Pasaporte o INE
    DocumentPhoto VARBINARY(MAX) NULL, -- Pasaporte o INE
    Notes NVARCHAR(MAX) NULL
);
