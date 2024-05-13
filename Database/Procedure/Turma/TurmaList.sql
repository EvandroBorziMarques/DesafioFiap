IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaList')
	        DROP PROCEDURE dbo.TurmaList
            GO
            
            CREATE PROCEDURE dbo.TurmaList
           	AS  
            BEGIN  
            	SELECT 
            	id as [id],
            	curso_id as [courseId],
            	turma as [class],
            	ano as [year]
            	FROM turma
            END  
            GO