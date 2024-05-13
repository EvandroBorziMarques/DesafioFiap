IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoCreate')
	        DROP PROCEDURE dbo.AlunoCreate
            GO
            
            CREATE PROCEDURE dbo.AlunoCreate(@name varchar(255), @user varchar(45), @password char(60))
            AS  
            BEGIN  
            	INSERT INTO
            	aluno
            	(nome, usuario, senha)
            	VALUES
            	(@name, @user, @password)
            END  
            GO