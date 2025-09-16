CREATE PROCEDURE Seguimiento_Insertar
    @CodigoProducto INT,
    @FechaRegistro DATETIME,
    @Mensaje NVARCHAR(500),
    @IDPersonalResponsable INT
AS
BEGIN
    INSERT INTO Seguimiento(CodigoProducto, FechaRegistro, Mensaje, IDPersonalResponsable)
    VALUES (@CodigoProducto, @FechaRegistro, @Mensaje, @IDPersonalResponsable);
END;
