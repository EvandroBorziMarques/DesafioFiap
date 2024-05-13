IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoDelete')
	        DROP PROCEDURE dbo.AlunoDelete
            GO
            
            CREATE PROCEDURE dbo.AlunoDelete(@id int)
            AS  
            BEGIN  
            	DELETE
            	FROM
            	aluno
            	where
            	id = @id
            END  
            GO