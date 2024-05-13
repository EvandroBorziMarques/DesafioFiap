IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoList')
	        DROP PROCEDURE dbo.AlunoList
            GO
            
            CREATE PROCEDURE dbo.AlunoList
           	AS  
            BEGIN  
            	SELECT 
            	id as [id],
            	nome as [name],
            	usuario as [user],
            	senha as [password]
            	FROM aluno
            END  
            GO