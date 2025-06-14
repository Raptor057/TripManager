CREATE TABLE [dbo].[Branches]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [BusinessId] INT NOT NULL,
    [BranchName] NVARCHAR(100) NOT NULL,
    [PhoneNumber] NVARCHAR(20),
    [Email] NVARCHAR(100),
    [City] NVARCHAR(100),
    [State] NVARCHAR(100),
    [Country] NVARCHAR(100),
    [Timezone] NVARCHAR(50),
    [IsActive] BIT NOT NULL DEFAULT 1,
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE()
);
