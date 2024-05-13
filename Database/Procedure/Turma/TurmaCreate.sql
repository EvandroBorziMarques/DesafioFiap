IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaCreate')
	        DROP PROCEDURE dbo.TurmaCreate
            GO
            
            CREATE PROCEDURE dbo.TurmaCreate(@id int, @courseId int, @class varchar(45), @year int)
            AS  
            BEGIN  
            	INSERT INTO
            	turma
            	(id, curso_id, turma, ano)
            	VALUES
            	(@id, @courseId, @class, @year)
            END  
            GO