CREATE TABLE [dbo].[BusinessInfo]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [BusinessName] NVARCHAR(200) NOT NULL,
    [LegalName] NVARCHAR(200),
    [RFC] NVARCHAR(50),
    [PhoneNumber] NVARCHAR(20),
    [Email] NVARCHAR(100),
    [Website] NVARCHAR(100),
    
    [Street] NVARCHAR(MAX),
    [ExteriorNumber] NVARCHAR(10),
    [InteriorNumber] NVARCHAR(10),
    [Neighborhood] NVARCHAR(MAX),
    [City] NVARCHAR(MAX),
    [State] NVARCHAR(MAX),
    [PostalCode] NVARCHAR(10),
    [Country] NVARCHAR(100) DEFAULT 'México',

    [Logo] VARBINARY(MAX),  -- Aquí se guarda el logo como bytes (base64 decodificado)
    [IsActive] BIT NOT NULL DEFAULT 1,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
