use TechSupport;
GO

IF OBJECT_ID('closeIncident') IS NOT NULL
	DROP PROCEDURE closeIncident
GO
	
CREATE PROCEDURE closeIncident
	@IncidentID int
AS
BEGIN
	UPDATE Incidents
	SET DateClosed = CURRENT_TIMESTAMP
	WHERE IncidentID = IncidentID;
	RETURN;
END;
GO