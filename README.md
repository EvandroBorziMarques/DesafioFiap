# 	API Aluno Turma

Desafio FIAP

## Features

- API CRUD que contém: :heavy_check_mark:
  - Aluno
    - Criar
    - Buscar Lista
    - Buscar por ID
    - Atualizar
    - Deletar
  - Turma
    - Criar
    - Buscar Lista
    - Buscar por ID
    - Atualizar
    - Deletar
  - Relacionamento entre Aluno e Turma
    - Criar
    - Deletar

## Tech Stack

<div style="display: inline_block">
    <img align="center" alt="Csharp" height="50" width="50" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg">
    <img align="center" alt="Dapper" height="50" width="50" src="https://api.nuget.org/v3-flatcontainer/dapper/2.1.35/icon">
    <img align="center" alt="Docker" height="70" width="70" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/docker/docker-original.svg" />
    <img align="center" alt="SqlServer" height="80" width="80" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRlNgLHpZ13cUUijowdXzk3Z9x-nTh6G-_KZWdzVoDuOg&s" />  
</div>
<br>
Tecnologias usadas para construir a aplicação

- .Net 8.0
- Dapper
- Docker / Docker Hub
- SqlServer

## Link imagem docker <a href="https://hub.docker.com/repository/docker/evandroborzi/sqlserver/general">SQLServer</a>.
### Se a imagem do docker acima apresentar algum problema, crie um container executando o comando abaixo:
```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=TesteFiap1234!@#$" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-CU14-ubuntu-20.04
```
### Caso necessite criar o banco de dados, os comandos estão no projeto "Database".

