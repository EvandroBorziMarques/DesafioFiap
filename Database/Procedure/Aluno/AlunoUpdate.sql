IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoUpdate')
	        DROP PROCEDURE dbo.AlunoUpdate
            GO
            
            CREATE PROCEDURE dbo.AlunoUpdate(@id int, @name varchar(255), @user varchar(45), @password char(60))
            AS  
            BEGIN  
            	UPDATE
            	aluno
            	SET
            	nome = @name,
            	usuario = @user,
            	senha = @password
            	where
            	id = @id
            END  
            GO