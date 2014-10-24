USE [BDBeca]
GO

/****** Object:  StoredProcedure [dbo].[PaObtenerBeneficiosPaCmb]    Script Date: 23/10/2014 06:41:23 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Randall Liu Lin
-- Create date: 23-10-2014
-- Description:	Obtiene los id´s y nombres de los beneficios de la tabla tbBeneficio
-- =============================================
CREATE PROCEDURE [dbo].[PaObtenerBeneficiosPaCmb]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IdBeneficio,Nombre
	FROM TbBeneficio

END
GO

