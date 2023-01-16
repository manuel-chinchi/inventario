USE Inventario;

CREATE TABLE Usuarios(
	Id INT IDENTITY(1,1),
	Nombre VARCHAR(50),
	Clave VARCHAR(50),
	PRIMARY KEY (Id)
);

CREATE TABLE Articulos(
	Id INT NOT NULL,
	Nombre VARCHAR(50),
	Descripcion VARCHAR(50),
	PRIMARY KEY (Id)
);