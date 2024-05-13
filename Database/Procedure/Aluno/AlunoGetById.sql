IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoGetById')
	        DROP PROCEDURE dbo.AlunoGetById
            GO            
            CREATE PROCEDURE dbo.AlunoGetById(@id int)
            AS  
            BEGIN  
            	Select
            	id as [id],
            	nome as [name],
            	usuario as [user],
            	senha as [password]
            	FROM
            	aluno
            	WHERE
            	id = @id
            END  
            GO