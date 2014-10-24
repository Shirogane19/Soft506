USE [BDBeca]
GO

/****** Object:  StoredProcedure [dbo].[PaInsertarBeneficioATipoBeca]    Script Date: 23/10/2014 06:40:14 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Randall Liu Lin
-- Create date: 23-10-2014
-- Description:	Inserta en la tabla tbRequisitosPorTipoBeca el idTipoBeca y idBeneficio
-- =============================================
CREATE PROCEDURE [dbo].[PaInsertarBeneficioATipoBeca]
	-- Add the parameters for the stored procedure here
	@idTipoBeca as int,
	@idBeneficio as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into TbBeneficiosPorTipoBeca(IdBeneficio,IdTipoBeca)
	values (@idBeneficio,@idTipoBeca)

END

GO

