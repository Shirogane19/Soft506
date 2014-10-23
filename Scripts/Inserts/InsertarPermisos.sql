USE [BDBeca]
GO

INSERT INTO [dbo].[TbPermiso]
           ([nombre]
           ,[descripcion])
     VALUES
           ('Módulo de usuarios', 'Acceso completo al módulo de usuarios'),
           ('Módulo académico', 'Acceso completo al módulo académico'),
		   ('Módulo de becas', 'Acceso completo al módulo de becas'),
		   ('Modulo de configuración', 'Acceso completo al módulo de configuración'),
		   ('Modulo de reportes','Acceso completo al módulo de reportes')           
GO


