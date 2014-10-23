-- =============================================
-- Author:		Juan Arias
-- Create date: 21/10/2014
-- Description:	Procedimiento para obtener los permisos.
-- =============================================
CREATE PROCEDURE PaObtenerPermisos
	-- Este procedimiento no recibe parámetros.
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [IdPermiso]
      ,[Nombre]
      ,[descripcion]
  
	FROM [dbo].[TbPermiso]

END
GO
