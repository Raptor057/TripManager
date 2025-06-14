CREATE TABLE [dbo].[BranchSettings]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [BranchId] INT NOT NULL,
    [SettingKey] NVARCHAR(100) NOT NULL,
    [SettingValue] NVARCHAR(MAX),
    [Description] NVARCHAR(255),
    [UpdatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE()

);
