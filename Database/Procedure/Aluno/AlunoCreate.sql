IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoCreate')
	        DROP PROCEDURE dbo.AlunoCreate
            GO
            
            CREATE PROCEDURE dbo.AlunoCreate(@id int, @name varchar(255), @user varchar(45), @password char(60))
            AS  
            BEGIN  
            	INSERT INTO
            	aluno
            	(id, nome, usuario, senha)
            	VALUES
            	(@id, @name, @user, @password)
            END  
            GO