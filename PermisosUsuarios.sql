CREATE DATABASE PermisosUsuarios;

USE PermisosUsuarios;

CREATE TABLE Producto(
codigoBarras VARCHAR(20) not null PRIMARY KEY,
Nombre VARCHAR(100),
Descripcion VARCHAR(100),
Marca VARCHAR(100));

INSERT INTO Herramientas VALUES('5296165461', 'Desarmador',17.5,'Trupper', 'Desarmador con rosca');
SELECT * FROM herramientas;
CREATE TABLE Herramientas(
codigoHerramientas VARCHAR(20) PRIMARY KEY,
Nombre VARCHAR(100),
Medida DECIMAL(5,2),
Marca VARCHAR(100),
Descripcion VARCHAR(100));

CREATE TABLE Usuarios(
idUsuario INT PRIMARY KEY AUTO_INCREMENT,
Nombre VARCHAR(100),
ApellidoP VARCHAR(70),
ApellidoM VARCHAR(70),
FechaNacimiento DATE,
RFC VARCHAR(13),
NIC VARCHAR(50) UNIQUE,
Contraseña VARCHAR(255),
idFormulario INT,
nombreFormulario ENUM('Producto','Herramientas','Administrador'));

/*VALIDAR USUARIO*/
DELIMITER //
CREATE PROCEDURE p_ValidarU
(
   IN _NIC VARCHAR(50), 
   IN _Contraseña VARCHAR(255)
)
BEGIN
    DECLARE x INT;
    SELECT COUNT(*) FROM Usuarios WHERE NIC=_NIC  AND Contraseña=_Contraseña INTO x;
    if X>0 then
    SELECT 'C0rr3cto' AS rs , (SELECT Tipo FROM Usuarios WHERE NIC=_NIC AND Contraseña=_Contraseña) AS tipo,
	 (SELECT Formulario FROM Usuarios WHERE NIC=_NIC AND Contraseña=_Contraseña) AS formulario;
	 
    ELSE
    SELECT 'Error' AS rs, 0 AS Tipo;
    END if;
END // 
DELIMITER ;

/*INSERTAR USUARIO*/
DELIMITER //

DROP PROCEDURE IF EXISTS p_InsertarUsuario;
CREATE PROCEDURE p_InsertarUsuario
(
  IN _idUsuario INT,
  IN _Nombre VARCHAR(100),
  IN _ApellidoP VARCHAR(70),
  IN _ApellidoM VARCHAR(70), 
  IN _FechaNacimiento DATE,
  IN _RFC VARCHAR(13),
  IN _NIC VARCHAR(50),
  IN _Contraseña VARCHAR(255),
  IN _idFormulario INT,
  IN _nombreFormulario ENUM('Producto','Herramientas','Administrador')
)
BEGIN
  DECLARE existe INT;

  SELECT COUNT(*) INTO existe FROM Usuarios WHERE idUsuario = _idUsuario;

  IF existe = 0 THEN
    INSERT INTO Usuarios (
      idUsuario, Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, NIC, Contraseña, idFormulario, nombreFormulario
    ) 
    VALUES (
      _idUsuario, _Nombre, _ApellidoP, _ApellidoM, _FechaNacimiento, _RFC, _NIC, _Contraseña, _idFormulario, _nombreFormulario
    );
  END IF;

END //

DELIMITER ;

/*ELIMINAR USUARIO*/
DELIMITER //
DROP PROCEDURE if EXISTS p_IEliminarUsuario;
CREATE PROCEDURE p_EliminarUsuario
(
  IN _idUsuario INT
)
BEGIN
DELETE FROM Usuarios WHERE idUsuario=_idUsuario;
END //
DELIMITER //

/*ACTUALIZAR USUARIO*/
SELECT * FROM  usuarios;
INSERT INTO usuarios VALUES(1,'Juan','Martinez','Ortega','2004-10-02','RASF014521CDS','JuanMa','juan1234',1,1);