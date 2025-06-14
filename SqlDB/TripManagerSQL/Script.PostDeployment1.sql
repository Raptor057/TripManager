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
