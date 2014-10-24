USE [BDBeca]
GO

/****** Object:  StoredProcedure [dbo].[PaInsertarRequisitosATipoBeca]    Script Date: 23/10/2014 06:40:32 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Randall Liu Lin 
-- Create date: 23-10-2014
-- Description:	Inserta en la tabla tbRequesitosPorTipoBeca el idTipoBeca y idRequisito
-- =============================================
CREATE PROCEDURE [dbo].[PaInsertarRequisitosATipoBeca]
	-- Add the parameters for the stored procedure here
	@idTipoBeca as int,
	@idRequisito as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into TbRequisitosPorTipoBeca(IdTipoBeca,IdRquisito)
	values (@idTipoBeca,@idRequisito)
END

GO

