CREATE PROCEDURE spAccesoSistema
(
	@nombre VARCHAR(50),
	@clave VARCHAR(50)
)
AS
BEGIN
	SELECT U.Id, U.Nombre, U.Clave
	FROM Usuarios U
	WHERE U.Nombre = @nombre and U.Clave = @clave
END