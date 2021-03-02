use TechSupport;
GO

IF OBJECT_ID('createIncident') IS NOT NULL
	DROP PROCEDURE createIncident
GO
	
CREATE PROCEDURE createIncident
	@CustomerID int,
	@ProductCode char(10),
	@Title varchar(50),
	@Description varchar(2000)
AS
BEGIN
	INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description)
	VALUES (@CustomerID, @ProductCode, CURRENT_TIMESTAMP, @Title, @Description);
	RETURN;
END;
GO