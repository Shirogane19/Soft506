USE [BDBeca]
GO

/****** Object:  StoredProcedure [dbo].[PaInsertarTipoBeca]    Script Date: 23/10/2014 06:41:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Randall Liu Lin
-- Create date: 23-10-2014
-- Description:	Inserta datos a la tabla TbTipoBeca y devuelve el id de esta inserción
-- =============================================
CREATE PROCEDURE [dbo].[PaInsertarTipoBeca] 
	@nombre as varchar(50),
	@descripcion as varchar(max),
	@estado as char(1),
	@idPeriodo as int
AS
BEGIN

	DECLARE @existeNombre int = 0

	SET NOCOUNT ON;

	SELECT @existeNombre = IdTipoBeca
	FROM TbTipoBeca
	WHERE Nombre = @nombre

	IF @existeNombre != 0
	PRINT 'Ya existe un tipo de beca con el nombre: ' + @nombre
	ELSE

    INSERT INTO TbTipoBeca(Nombre,Descripcion,Estado,IdPeriodo)
	VALUES(@nombre,@descripcion,@estado,@idPeriodo)

	SELECT IdTipoBeca
	FROM TbTipoBeca
	WHERE nombre = @nombre

END
GO

