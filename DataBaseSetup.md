# Configuración de la Base de Datos

Este archivo contiene el script necesario para crear la base de datos utilizada en el software de biblioteca universitaria.

## Importante: Modificación de ConnectionString
En las clases que contienen `Database` en su nombre, es necesario modificar la variable `connectionString`. Se debe cambiar el valor del `Server` con el nombre del servidor local donde se ejecutará la base de datos.

Ejemplo de línea a modificar en C#:

```csharp
private static string connectionString = "Server=TU_SERVIDOR; Database=ProgramacionDataBase; Trusted_Connection=True;";
```

Reemplazar `TU_SERVIDOR` con el nombre correcto de su servidor SQL.

## Script de Creación de Base de Datos

```sql
CREATE DATABASE ProgramacionDataBase;
USE ProgramacionDataBase;

CREATE TABLE NormalUser (
    userId INT PRIMARY KEY IDENTITY(1,1),
    cedula INT,
    firstName NVARCHAR(50) NOT NULL,
    lastName NVARCHAR(50) NOT NULL,
    middleName NVARCHAR(50),
    age INT CHECK (age >= 14),
    arrears CHAR(2) DEFAULT '0',
    email NVARCHAR(100) UNIQUE NOT NULL,
    userName NVARCHAR(50) UNIQUE NOT NULL,
    userPassword NVARCHAR(50) NOT NULL,
    typeUser NVARCHAR(15)
);

CREATE TABLE Librarian (
    librarianId INT PRIMARY KEY IDENTITY(1,1),
    userId INT,
    firstName NVARCHAR(50) NOT NULL,
    lastName NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    FOREIGN KEY(userId) REFERENCES NormalUser(userId)
);

CREATE TABLE Material (
    materialId INT PRIMARY KEY,
    title NVARCHAR(100) NOT NULL,
    author NVARCHAR(100),
    publicationYear INT CHECK (publicationYear > 0),
    category NVARCHAR(70),
    materialType NVARCHAR(20) CHECK (materialType IN ('Book', 'AudioVisual')) NOT NULL,
    materialStatus NVARCHAR(20) CHECK (materialStatus IN ('Available', 'Reserved', 'Loaned')) DEFAULT 'Available',
    materialCondition NVARCHAR(20) CHECK (materialCondition IN ('NEW', 'USED', 'WORN', 'DAMAGED')),
    pageBook INT,
    duration NVARCHAR(10),
    formato NVARCHAR(50)
);

CREATE TABLE Reservation (
    reservationId INT PRIMARY KEY IDENTITY(1,1),
    userId INT NOT NULL,
    materialId INT NOT NULL,
    requestDate DATETIME2(3),
    expirationDate DATETIME2(3),
    reservationStatus NVARCHAR(20) CHECK (reservationStatus IN ('Pending', 'Accepted', 'Expired','Rejected','Canceled')) DEFAULT 'Pending',
    FOREIGN KEY(userId) REFERENCES NormalUser(userId),
    FOREIGN KEY(materialId) REFERENCES Material(materialId)
);

CREATE TABLE Loan (
    loanId INT PRIMARY KEY IDENTITY(1,1),
    reservationId INT NOT NULL UNIQUE,
    librarianId INT NOT NULL,
    startDate DATETIME2(3) NOT NULL,
    endDate DATETIME2(3) NOT NULL,
    returnDate DATETIME2(3),
    loanStatus NVARCHAR(20) CHECK (loanStatus IN ('Active', 'Overdue', 'Completed','Canceled')) NOT NULL DEFAULT 'Ongoing',
    FOREIGN KEY(reservationId) REFERENCES Reservation(reservationId),
    FOREIGN KEY(librarianId) REFERENCES Librarian(librarianId)
);

Insertar datos en NormalUser
INSERT INTO NormalUser (cedula, firstName, lastName, middleName, age, arrears, email, userName, userPassword, typeUser)
VALUES 
(1001, 'Juan', 'Pérez', 'Carlos', 25, '0', 'juan.perez@email.com', 'JuanPerez25', 'pass1234', 'Student'),
(21002, 'María', 'Gómez', 'Elena', 30, '0', 'maria.gomez@email.com', 'MariaGomez30', 'securePass', 'Teacher'),
(31003, 'Luis', 'Fernández', 'Alberto', 40, '0', 'luis.fernandez@email.com', 'LuisFernandez40', 'mypassword', 'Employee'),
(41004, 'Ana', 'Martínez', 'Sofía', 28, '0', 'ana.martinez@email.com', 'AnaMartinez28', 'strongPass', 'Librarian'),
(51005, 'Pedro', 'Sánchez', 'Javier', 35, '0', 'pedro.sanchez@email.com', 'PedroSanchez35', 'adminPass', 'Administrator');

Insertar datos en Material
INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus, materialCondition, pageBook, duration, formato)
VALUES 
(1, 'Cien años de soledad', 'Gabriel García Márquez', 1967, 'History', 'Book', 'Available', 'Used', 417, NULL, NULL),
(2, 'El principito', 'Antoine de Saint-Exupéry', 1943, 'Education', 'Book', 'Available', 'New', 96, NULL, NULL),
(3, 'Inception', 'Christopher Nolan', 2010, 'Engineering', 'AudioVisual', 'Available', 'New', NULL, '148 min', 'Blu-ray'),
(4, 'Interstellar', 'Christopher Nolan', 2014, 'Mathematics', 'AudioVisual', 'Available', 'Used', NULL, '169 min', 'DVD'),
(5, 'Don Quijote de la Mancha', 'Miguel de Cervantes', 1605, 'Law', 'Book', 'Available', 'Worn', 863, NULL, NULL);
```
