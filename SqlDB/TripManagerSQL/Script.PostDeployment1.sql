-- This file contains SQL statements that will be executed after the build script.

IF OBJECT_ID('dbo.TimeZones', 'V') IS NULL
EXEC('
CREATE VIEW [dbo].[TimeZones]
AS
SELECT
    name,
    current_utc_offset,
    is_currently_dst
FROM sys.time_zone_info
');
GO

-- Insert default roles if they don't already exist
IF NOT EXISTS (SELECT 1 FROM Roles WHERE RoleName = 'Admin')
BEGIN
    INSERT INTO Roles (RoleName, Description) VALUES
    ('Admin', 'Acceso total al sistema'),
    ('Dispatcher', 'Programa viajes y gestiona pagos'),
    ('Driver', 'Solo puede ver sus propios viajes'),
    ('Clerk', 'Atiende clientes y confirma reservas');
END
GO
