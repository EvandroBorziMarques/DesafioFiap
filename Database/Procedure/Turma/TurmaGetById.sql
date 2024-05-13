IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaGetById')
	        DROP PROCEDURE dbo.TurmaGetById
            GO            
            CREATE PROCEDURE dbo.TurmaGetById(@id int)
            AS  
            BEGIN  
            	Select
            	id as [id],
            	curso_id as [courseId],
            	turma as [class],
            	ano as [year]
            	FROM
            	turma
            	WHERE
            	id = @id
            END  
            GO