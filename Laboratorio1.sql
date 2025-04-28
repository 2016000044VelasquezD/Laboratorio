-- Crea una base de datos
Create database Empresa_FIXO;

-- Selecciona la base de datos recién creada para operar sobre ella
use Empresa_FIXO;

CREATE TABLE direccion ( -- Crea la tabla "direction" para direcciones
    idDireccion INT(11) PRIMARY KEY, -- -- Clave primaria (identificador único)
    Direccion VARCHAR(45), -- se ingresa una dirección física
    ciudad VARCHAR(45), -- se ingresa una ciudad asociada a la dirección
    departamento VARCHAR(45) --  Departamento o región
);

CREATE TABLE cliente ( -- Tabla para almacenar clientes
    idCliente INT(11) PRIMARY KEY, -- Clave primaria del cliente
    nombre VARCHAR(45), -- Nombre del cliente
    apellido VARCHAR(45), -- Apellido del cliente
    Direccion_idDireccion INT(11), -- Clave foránea que referencia a "direction"
    FOREIGN KEY (Direccion_idDireccion) REFERENCES direccion(idDireccion)  on delete cascade 
    -- Si se borra una dirección, se borran los clientes asociados
);

CREATE TABLE renta ( --  Tabla para registrar alquileres
    idRenta INT(11) PRIMARY KEY, -- Identificador único del alquiler
    Fecha_renta DATE, -- Fecha de inicio del alquiler
    Fecha_devolucion DATE, -- Fecha de la devolucion de la pelicula
    cliente_idCliente INT(11), -- Clave foránea que referencia al cliente
    FOREIGN KEY (cliente_idCliente) REFERENCES cliente(idCliente)  on delete cascade 
    -- Si se borra un cliente, se borran sus alquileres
);
-- 

CREATE TABLE categoria ( -- Tabla para categorías de películas
    idCategoria INT(11) PRIMARY KEY, -- Identificador único de la categoría
    nombre_categoria VARCHAR(45) -- El Nombre de la categoria de la pelicula
);

CREATE TABLE peliculas ( -- Se crea una tabla donde se almacenan las peliculas
    idPeliculas INT(11) PRIMARY KEY, -- Identificador de la película
    Titulo VARCHAR(45), -- El Título de la película
    Categoria_idCategoria INT(11), -- Clave foránea que referencia a "categoria"
    FOREIGN KEY (Categoria_idCategoria) REFERENCES categoria(idCategoria)  on delete cascade 
    -- Si se borra una categoría, se borran sus películas
);

CREATE TABLE inventario ( -- Tabla para gestionar el inventario
    idInventario INT(11) PRIMARY KEY, -- Identificador un ítem en inventario
    peliculas_idPeliculas INT(11), -- Clave foránea que referencia a "peliculas"
    renta_idRenta INT(11), -- Clave foránea que referencia a "renta"
    FOREIGN KEY (peliculas_idPeliculas) REFERENCES peliculas(idPeliculas)  on delete cascade,
    FOREIGN KEY (renta_idRenta) REFERENCES renta(idRenta) on delete cascade 
    -- si se borran la pelicula y la renta se borra el inventario
);

CREATE TABLE centrales (-- Tabla para centrales
    idcentral INT PRIMARY KEY, -- Identificador una central
    nombre_de_la_central VARCHAR(45),-- Nombre de la central
    Direccion_idDireccion INT,-- Clave foránea que debería apuntar a "direction"
    FOREIGN KEY (Direccion_idDireccion) REFERENCES direccion(idDireccion)  on delete cascade
    -- si se borran las direcciones se borran las centrales
);

CREATE TABLE Trabajadores ( -- Tabla para empleados
    idTrabajador INT PRIMARY KEY, -- Identificador único del trabajador
    nombre VARCHAR(45), -- Nombre del trabajador
    puesto VARCHAR(45),-- suu puesto en la central
    idcentral INT,-- el ID de la central
    FOREIGN KEY (idcentral) REFERENCES centrales(idcentral)  on delete cascade 
    -- si se borra la central se borran los trabajadores
);



INSERT INTO direccion(idDireccion,Direccion,ciudad,departamento)
VALUES -- se insertan datos con el orden de las columnas
('684684','Av Central 123', 'Ciudad A', 'Depto A'), -- Datos
('6468421','Calle Luna 456', 'Ciudad B', 'Depto B'),
('784351','Zona 1, Edificio X', 'Ciudad C', 'Depto C'),
('87512','Av. Reforma 789', 'Ciudad D', 'Depto D'),
('215448','Boulevard Sur 101', 'Ciudad E', 'Depto E');

INSERT INTO cliente(idCliente,nombre,apellido,Direccion_idDireccion)
VALUES -- se insertan datos con el orden de las columnas
('44684','Carlos', 'Pérez','784351'), -- Datos
('519816','Juliana', 'Martínez','684684'),
('5419735','Luis', 'Gómez','6468421'),
('239756','Ana', 'Juliana','215448'),
('753426','Pedro', 'Juárez','87512');

INSERT INTO renta(idRenta,Fecha_renta,Fecha_devolucion,cliente_idCliente)
VALUES -- se insertan datos con el orden de las columnas
('55463','2024-04-01', '2029-04-05','44684'),-- Datos
('165489','2024-04-02', '2026-04-06','239756'),
('83542','2024-04-03', '2027-04-07','519816'),
('79246','2024-04-04', '2025-04-08','753426'),
('103845','2024-04-05', '2030-04-09','5419735');

INSERT INTO categoria(idCategoria,nombre_categoria)
 VALUES -- se insertan datos con el orden de las columnas
('843513','Acción'),-- Datos
('21434','Comedia'),
('16579','Drama'),
('26579','Terror'),
('359764','Aventura');

INSERT INTO peliculas(idPeliculas,Titulo,Categoria_idCategoria)
 VALUES -- se insertan datos con el orden de las columnas
(1, 'Capitán América: Brave New World.','843513'),-- Datos
(2, 'Sonic, la película','21434'),
(3, 'Oppenheimer','16579'),
(4, 'La bruja','26579'),
(5, 'POKEMON1','359764');

INSERT INTO inventario (idInventario,peliculas_idPeliculas,renta_idRenta)
VALUES -- se insertan datos con el orden de las columnas
(1, 1, 103845),-- Datos
(2, 2, 83542),
(3, 3, 165489),
(4, 4, 79246),
(5, 5, 55463);


INSERT INTO centrales(idcentral,nombre_de_la_central,Direccion_idDireccion) 
VALUES -- se insertan datos con el orden de las columnas
(12345, 'Sucursal Centro', 684684),-- Datos
(1234, 'Sucursal Centro', 6468421),
(123, 'Sucursal Centro', 784351),
(12, 'Sucursal Centro', 87512),
(1, 'Sucursal Norte', 215448);

INSERT INTO Trabajadores(idTrabajador,nombre,puesto,idcentral)
VALUES -- se insertan datos con el orden de las columnas
(21547896, 'Juliana', 'Gerente', 12),-- Datos
(45967852, 'Juliana', 'Gerente', 123),
(15346876, 'Juliana', 'Gerente', 1),
(78962453, 'Juliana', 'Gerente', 12345),
(25768923, 'Carlos', 'Asistente', 1234);


select * from direccion; -- Ejecuta la tabla Dirrecion
select * from cliente; -- Ejecuta la tabla Cliente
select * from renta; -- Ejecuta la tabla renta
select * from categoria; -- Ejecuta la tabla cateforia
select * from peliculas; -- Ejecuta la tabla peliculas
select * from inventario; -- Ejecuta la tabla inventario	


SELECT * FROM cliente WHERE nombre = 'Juliana'; -- Se busca en la tabla cliente el nombre juliana
SELECT * FROM categoria ORDER BY nombre_categoria ASC; -- Ordenar categorías alfabéticamente
SELECT * FROM renta ORDER BY Fecha_renta DESC; -- se ordenan las fechas


DELETE FROM peliculas WHERE Titulo = 'POKEMON1'; -- Borrar una película por título




drop database Empresa_FIXO; 