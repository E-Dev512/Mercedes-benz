CREATE PROCEDURE sp_BuscarCategoria
	@Nombre NVARCHAR(100)
AS
BEGIN
    SELECT Id,Nombre
    FROM Categorias
    WHERE Nombre LIKE @Nombre + '%';
END;
-------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_InsertarCategoria
	@Nombre VARCHAR(100)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM Categorias WHERE  Nombre=@Nombre)
BEGIN
	INSERT INTO Categorias VALUES (@Nombre)
	SELECT CODERROR = 0, MENSAJE = '0'
END
ELSE
	SELECT CODERROR = 1, MENSAJE = '1'
END
----------------------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_ModificarCategoria
    @IdCategoria INT,
    @NombreNuevo NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT * FROM Categorias WHERE Id = @IdCategoria)
    BEGIN
        IF EXISTS (SELECT * FROM Categorias WHERE Nombre = @NombreNuevo)
        BEGIN
            SELECT CODERROR = 1, MENSAJE = 'Ya existe una categoría con ese nombre. Elige otro nombre.'
        END
        ELSE
        BEGIN
            UPDATE Categorias
            SET Nombre = @NombreNuevo
            WHERE Id = @IdCategoria;

            SELECT CODERROR = 0, MENSAJE = 'Categoría modificada con éxito.'
        END
    END
    ELSE
    BEGIN
        SELECT CODERROR = 1, MENSAJE = 'Categoría no encontrada.'
    END
END
------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_ObtenerCategorias
    @Grupo INT
AS
BEGIN
    DECLARE @Offset INT = (@Grupo - 1) * 18;

    SELECT Id, Nombre 
    FROM Categorias
    ORDER BY Id
    OFFSET @Offset ROWS
    FETCH NEXT 18 ROWS ONLY;
END;
-----------------------------------------------------------

CREATE proc sp_EliminarCategoria
	@IdCategoria int
AS
BEGIN
    IF EXISTS (SELECT * FROM Categorias WHERE Id = @IdCategoria)
    BEGIN
        DELETE FROM Categorias WHERE Id = @IdCategoria;
        SELECT CodError = 0, Mensaje = 'Se eliminó la categoria con éxito';
    END
    ELSE
    BEGIN
        SELECT CodError = 1, Mensaje = 'La categoria no existe';
    END
END
GO
--------------------------------------------------------

CREATE PROCEDURE sp_ObtenerTotalCategorias
AS
BEGIN
    DECLARE @Total INT;

    SELECT @Total = COUNT(*)
    FROM Categorias;

    SELECT @Total AS TotalFilas;
END;
GO


