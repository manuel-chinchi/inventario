USE Inventario;

-- Set Usuarios
INSERT INTO Usuarios (Nombre, Clave) VALUES ('admin', '1234');
INSERT INTO Usuarios (Nombre, Clave) VALUES ('mchinchi', '1234');
INSERT INTO Usuarios (Nombre, Clave) VALUES ('jperez', '1234');

-- Set Articulos
INSERT INTO Articulos (Id, Nombre, Descripcion) VALUES (1,'mesa', 'Mesa 4x1.5m');
INSERT INTO Articulos (Id, Nombre, Descripcion) VALUES (2, 'silla', 'Sila 40x60cm');
INSERT INTO Articulos (Id, Nombre, Descripcion) VALUES (3, 'baldes', 'Baldes 4L');