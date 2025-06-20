CREATE TABLE [dbo].[Users]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Username] NVARCHAR(100) NOT NULL UNIQUE,
    [Email] NVARCHAR(256) NOT NULL UNIQUE,
    [PasswordHash] NVARCHAR(256) NOT NULL,
    [FullName] NVARCHAR(200),
    [IsActive] BIT NOT NULL DEFAULT 1,
    [RoleId] INT NOT NULL DEFAULT 2,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
