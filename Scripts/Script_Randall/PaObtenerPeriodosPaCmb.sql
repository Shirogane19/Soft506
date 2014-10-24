USE [BDBeca]
GO

/****** Object:  StoredProcedure [dbo].[PaObtenerPeriodosPaCmb]    Script Date: 23/10/2014 06:41:56 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Randall Liu Lin
-- Create date: 23-10-2014
-- Description:	Obtiene el id y tiempo de la tabla tbPeriodo
-- =============================================
CREATE PROCEDURE [dbo].[PaObtenerPeriodosPaCmb] 
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT IdPeriodo,Tiempo
	FROM TbPeriodo

END

GO

