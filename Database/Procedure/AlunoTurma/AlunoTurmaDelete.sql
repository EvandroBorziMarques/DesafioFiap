IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoTurmaDelete')
	        DROP PROCEDURE dbo.AlunoTurmaDelete
            GO
            
            CREATE PROCEDURE dbo.AlunoTurmaDelete(@studentId int, @classId int)
            AS  
            BEGIN  
            	DELETE
            	FROM
            	aluno_turma
            	where
            	aluno_id = @studentId AND turma_id = @classId
            	
            END  
            GO