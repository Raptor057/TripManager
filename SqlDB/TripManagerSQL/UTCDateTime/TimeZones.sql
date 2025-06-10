CREATE VIEW [dbo].[TimeZones]
AS
SELECT
    name,
    current_utc_offset,
    is_currently_dst
FROM
    sys.time_zone_info;
GO