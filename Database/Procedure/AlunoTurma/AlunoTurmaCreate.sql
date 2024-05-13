IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'AlunoTurmaCreate')
	        DROP PROCEDURE dbo.AlunoTurmaCreate
            GO
            
            CREATE PROCEDURE dbo.AlunoTurmaCreate(@studentId int, @classId int)
            AS  
            BEGIN  
            	INSERT INTO
            	aluno_turma
            	(aluno_id, turma_id)
            	VALUES
            	(@studentId, @classId)
            END  
            GO