## Projeto
#### Back-end
Tecnologia: .NET 9.0
Variáveis de ambiente:
- DB_HOST
- DB_PORT
- DB_DB
- DB_USER
- DB_PASS

#### Database
Tecnologia: MySQL 8
Variáveis de ambiente:
- MYSQL_ROOT_PASSWORD
- MYSQL_DATABASE
- MYSQL_USER
- MYSQL_PASSWORD

#### Front-end
[! Nada definido, em aberto para você !]


## Detalhes

### Docker Compose
    127.0.0.1 (Localhost): É o modo "antissocial". A API só conversa com quem está 
    dentro do próprio container. Quem tenta acessar de fora (sua máquina/Postman) 
    fica trancado para fora.

    0.0.0.0: É o modo "portas abertas". A API aceita conexões de qualquer lugar, 
    permitindo que o Docker repasse os testes da sua máquina para dentro do 
    container.
Adicionar as variaveis de ambiente do container do backend: ASPNETCORE_URLS=http://0.0.0.0:8080





### Dockerfile
Adicionar ao Dockerfile para rodar corretamente: --no-launch-profile




### Código
- Criar o .sln geral
#### Program:
```cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();
builder.Services.AddUseCases();
builder.Services.ConfigureDb();

var app = builder.Build();
await app.Migrate();
app.Run();
```