IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaCreate')
	        DROP PROCEDURE dbo.TurmaCreate
            GO
            
            CREATE PROCEDURE dbo.TurmaCreate(@courseId int, @class varchar(45), @year int)
            AS  
            BEGIN  
            	INSERT INTO
            	turma
            	(curso_id, turma, ano)
            	VALUES
            	(@courseId, @class, @year)
            END  
            GO