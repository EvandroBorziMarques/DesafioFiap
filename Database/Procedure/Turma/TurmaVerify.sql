IF EXISTS(SELECT name FROM sys.procedures WHERE name = 'TurmaVerify')
	        DROP PROCEDURE dbo.TurmaVerify
            GO
            
            CREATE PROCEDURE dbo.TurmaVerify(@class varchar(45))
            AS  
            BEGIN  
            	select             		
					Count (turma) as [turma]
				FROM 
					turma
				where 
					turma = UPPER(@class)
            END  
            GO