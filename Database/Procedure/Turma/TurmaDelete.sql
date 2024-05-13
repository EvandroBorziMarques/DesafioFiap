IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaDelete')
	        DROP PROCEDURE dbo.TurmaDelete
            GO
            
            CREATE PROCEDURE dbo.TurmaDelete(@id int)
            AS  
            BEGIN  
            	DELETE
            	FROM
            	turma
            	where
            	id = @id
            END  
            GO