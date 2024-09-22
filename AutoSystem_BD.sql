create database AutoSystem_BD
go

use AutoSystem_BD
go

CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
);
GO

CREATE TABLE Proveedor (
    ProveedorID INT PRIMARY KEY IDENTITY(1,1),
    NombreProveedor NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100),
    Telefono NVARCHAR(20),
    Direccion NVARCHAR(255)
);
GO

CREATE TABLE Producto (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Detalle NVARCHAR(255),
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    CategoriaID INT,
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(Id)
);
GO