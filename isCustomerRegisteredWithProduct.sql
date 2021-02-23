use TechSupport;
GO

IF OBJECT_ID('isCustomerRegisteredToProduct') IS NOT NULL
	DROP PROCEDURE isCustomerRegisteredToProduct
GO
	
CREATE PROCEDURE isCustomerRegisteredToProduct
	@CustomerID int,
	@ProductCode char(10),
	@registered bit OUTPUT
AS
BEGIN
	SET @registered = (SELECT COUNT(*) FROM Registrations WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode);
	RETURN;
END;
GO