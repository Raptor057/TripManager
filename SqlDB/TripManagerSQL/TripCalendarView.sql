CREATE VIEW [dbo].[TripCalendarView]
  AS
  SELECT 
  ts.TripScheduleId,
  lo.NameOrigin,
  ld.NameDestination,
  ts.ScheduledDeparture,
  ts.ScheduledArrival,
  d.FirstName + ' ' + d.LastName AS DriverName,
  t.LicensePlate
FROM TripSchedule ts
JOIN LocationOrigin lo ON ts.LocationOriginId = lo.LocationOriginId
JOIN LocationDestination ld ON ts.LocationDestinationId = ld.LocationDestinationId
JOIN Driver d ON ts.DriverId = d.DriverId
JOIN Truck t ON ts.TruckId = t.TruckId
