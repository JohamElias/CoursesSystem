DROP TABLE IF EXISTS curso;
DROP TABLE IF EXISTS especialidad;
CREATE TABLE especialidad(
	id_especialidad INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    activo TINYINT
)ENGINE=innodb;
CREATE TABLE curso(
	id_curso INT PRIMARY KEY AUTO_INCREMENT,
    fid_especialidad INT,
    nombre VARCHAR(100),
    clave VARCHAR(6),
    creditos INT,
    precio DECIMAL(10,2),
    fecha_inicio DATE,
    fecha_fin DATE,
    activo TINYINT,
    FOREIGN KEY(fid_especialidad) REFERENCES especialidad(id_especialidad)
)ENGINE=innodb;
INSERT INTO especialidad(nombre,activo) values('INGENIERIA CIVIL',1);
INSERT INTO especialidad(nombre,activo) values('INGENIERIA INDUSTRIAL',1);
INSERT INTO especialidad(nombre,activo) values('INGENIERIA INFORMATICA',1);
INSERT INTO especialidad(nombre,activo) values('INGENIERIA MECANICA',1);
INSERT INTO especialidad(nombre,activo) values('INGENIERIA DE MINAS',1);
INSERT INTO especialidad(nombre,activo) values('INGENIERIA ELECTRONICA',1);
INSERT INTO especialidad(nombre,activo) values('INGENIERIA DE LAS TELECOMUNICACIONES',1);
DROP PROCEDURE IF EXISTS LISTAR_TODAS_ESPECIALIDADES;
DROP PROCEDURE IF EXISTS INSERTAR_CURSO;
DROP PROCEDURE IF EXISTS LISTAR_CURSOS_X_NOMBRE;
DELIMITER $
CREATE PROCEDURE LISTAR_TODAS_ESPECIALIDADES()
BEGIN
	SELECT id_especialidad, nombre, activo FROM especialidad WHERE especialidad.activo = 1;
END$
CREATE PROCEDURE LISTAR_CURSOS_X_NOMBRE(
	IN _nombre VARCHAR(100)
)
BEGIN
	SELECT curso.id_curso, curso.nombre as nombre_curso, curso.clave, curso.creditos, curso.precio, curso.fecha_inicio, curso.fecha_fin, especialidad.id_especialidad, especialidad.nombre as nombre_especialidad FROM curso INNER JOIN especialidad ON curso.fid_especialidad = especialidad.id_especialidad WHERE curso.nombre LIKE CONCAT('%',_nombre,'%') and curso.activo = 1;
END$
CREATE PROCEDURE INSERTAR_CURSO(
	OUT _id_curso INT,
    IN _fid_especialidad INT,
    IN _nombre VARCHAR(100),
    IN _clave VARCHAR(6),
    IN _creditos INT,
    IN _precio DECIMAL(10,2),
    IN _fecha_inicio DATE,
    IN _fecha_fin DATE
)
BEGIN
	INSERT INTO curso(fid_especialidad,nombre,clave,creditos,precio,fecha_inicio,fecha_fin,activo) VALUES(_fid_especialidad,_nombre,_clave,_creditos,_precio,_fecha_inicio,_fecha_fin,1);
    SET _id_curso = @@last_insert_id;
END$