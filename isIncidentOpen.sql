USE [TechSupport]
GO

IF OBJECT_ID('isIncidentOpen') IS NOT NULL
	DROP PROCEDURE isIncidentOpen
GO
	
CREATE PROCEDURE isIncidentOpen
	@IncidentID int,
	@isOpen bit out
AS
BEGIN
	SET @isOpen = (SELECT CAST (CASE
                    WHEN DateClosed IS NULL THEN 1
                    ELSE 0
                    END AS BIT) AS isOpen
    FROM Incidents
    WHERE Incidents.IncidentID = @incidentID);
	RETURN;
END;
