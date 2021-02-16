use TechSupport;
GO

IF OBJECT_ID('createIncident') IS NOT NULL
	DROP PROCEDURE createIncident
GO
	
CREATE PROCEDURE createIncident
	@CustomerName varchar(50),
	@ProductName varchar(50),
	@Title varchar(50),
	@Description varchar(2000),
	@message varchar(100) OUTPUT
AS
BEGIN
	DECLARE @CustomerID int;
	DECLARE @ProductCode char(10);
	DECLARE @registered bit;

	SET @CustomerID = (SELECT CustomerID From Customers WHERE Name = @CustomerName);
	SET @ProductCode = (SELECT ProductCode FROM Products WHERE Name = @ProductName);

	SET @registered = (SELECT COUNT(*) FROM Registrations WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode);
	IF (@registered = 1) 
		BEGIN
			INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description)
			VALUES (@CustomerID, @ProductCode, CURRENT_TIMESTAMP, @Title, @Description);
			SET @message = 'Incident created';
		END
	ELSE
		SET @message = 'Customer not registered to product';

	RETURN;
END;
GO