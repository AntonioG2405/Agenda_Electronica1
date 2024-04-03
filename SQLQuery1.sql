create database AgendaElectronica2
go
drop table agenda#2
create table agenda#2
(
ID          int primary key identity (1,1), 
Titulo      nvarchar(max) not null,
Fecha       nvarchar (max)not null, 
Categoria   nvarchar (max) not null, 
Descripcion nvarchar (max) not null
)
go


insert into agenda#2 values ('Cumplea;os de penelope','2024-09-18','Cumpleaños','Este dia debes llevarle un regalo  a tu bebecita hermosa')


--Procesos almacenados

--mostrar datos
create procedure sp_list
as
select * from agenda#2

exec sp_list
-------------------------------------------------------------------------------------------------------------------------------
--Solo funcionan en el sql no en el codigo    ||
                              --              \/
-------------------------------------------------------------------------------------------------------------------------------
--Agregar

CREATE PROCEDURE sp_Agregar22
	--@Id int,
    @Titulo nvarchar(max),
    @Fecha nvarchar(max),
    @Categoria nvarchar(max),
    @Descripcion nvarchar(max)
AS
BEGIN
   IF NOT EXISTS (SELECT 1 FROM agenda#2 WHERE Titulo = @Titulo)
    BEGIN
        INSERT INTO agenda#2 (Titulo,Fecha, Categoria, Descripcion)
        VALUES (@Titulo, @Fecha, @Categoria, @Descripcion);
        SELECT 'Registro insertado correctamente.';
    END
    ELSE
    BEGIN
        SELECT 'El título ya existe en la tabla.';
    END
END


exec sp_Agregar22'umplea;os de penelope','2024-05-24','fiesta','Mi cummple'

--Editar
CREATE PROCEDURE sp_ActualizarAgenda2
    @ID INT,
    @Titulo NVARCHAR(30),
    @Fecha NVARCHAR(30),
    @Categoria NVARCHAR(30),
    @Descripcion NVARCHAR(500)
AS
BEGIN
    UPDATE agenda#2
    SET Titulo = @Titulo,
        Fecha = @Fecha,
        Categoria = @Categoria,
        Descripcion = @Descripcion
    WHERE ID = @ID
END



--Borrar
CREATE PROCEDURE sp_BorrarAgenda2
    @ID INT
AS
BEGIN
    DELETE FROM agenda#2 WHERE ID = @ID
END

exec sp_BorrarAgenda2 13
exec sp_list

--Buscar datos
create proc sp_buscar
@BUSCAR NVARCHAR (100)
as
select * from agenda#2 where Titulo + Categoria + Descripcion + Fecha like '%' +  @BUSCAR + '%'

exec sp_Buscar  'penelope'


