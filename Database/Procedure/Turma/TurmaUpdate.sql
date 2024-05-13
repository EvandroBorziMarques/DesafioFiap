IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaUpdate')
	        DROP PROCEDURE dbo.TurmaUpdate
            GO
            
            CREATE PROCEDURE dbo.TurmaUpdate(@id int, @courseId int, @class varchar(45), @year int)
            AS  
            BEGIN  
            	UPDATE
            	turma
            	SET
            	curso_id = @courseId,
            	turma = @class,
            	ano = @year
            	where
            	id = @id
            END  
            GO