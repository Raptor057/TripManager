CREATE TABLE Roles (
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50) NOT NULL UNIQUE, -- Ej: Admin, Dispatcher, Driver, Supervisor
    Description NVARCHAR(255) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedAt DATETIME NULL DEFAULT GETUTCDATE()
);
