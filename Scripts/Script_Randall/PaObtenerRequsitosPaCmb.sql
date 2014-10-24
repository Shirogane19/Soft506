USE [BDBeca]
GO

/****** Object:  StoredProcedure [dbo].[PaObtenerRequsitosPaCmb]    Script Date: 23/10/2014 06:42:32 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Randall Liu Lin
-- Create date: 23-10-2014
-- Description:	Obtiene el idRequesito y el nombre del requisito de la tabla TbRequisito
-- =============================================
Create PROCEDURE [dbo].[PaObtenerRequsitosPaCmb]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IdRequisito,Nombre
	FROM TbRequisito
END

GO

