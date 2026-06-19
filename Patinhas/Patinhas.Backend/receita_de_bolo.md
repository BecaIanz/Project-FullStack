### 01. Criar modelos
    Usamos modelos pronto que contem modelo de animal, foto, usario, ong e match nosso modelo é a Entities, Nosso modelo fica na Pasta Patinhas.Domain.

### 02. Criar DbContext
    Usamos dbcontext pronto e nele contem às conexções com o banco. 

### 03. Configurar DbContext e conexão com o SQL (variável de ambiente)
    Usamos dbcontext pronto e nele contem às conexções com o banco.

### 04. Criar e rodar migrations
     Usamos pronto nele contem um modelo de FrameworkCore.

    Nosso use case fica na pasta Patinhas.Infrastructure.

### 05. Definir UseCases
    Criamaos e Definimos create, delete, update,addPhoto para Usuarios, Animais e ong
    Tambem fizemos um getfeed para filtrar o usuario escolido.

    Nosso use case fica na pasta Patinhas.Application.


### 06. Definir Payloads e Responses dos Payloads
    Definimos Payloads e responses de acordo com com cada user case  como create, delete, update,addPhoto para Usuarios, Animais e ong de acordo com as Entities


### 07. Implementar Endpoints usando UseCases
    Definindo serviços primeiro

### 08. Configurar UseCases como serviços
    implemetamos o o serviço e  definimos as regras de negocio no use case.

### 09. Definir Serviços
    Definimos os serviços de 
    Animal: 
        Contem getall,
        Create Animal,
        Delete Animal,
        Update Animal,
        Add Animal Photo, 
        Remove Animal Photo,
        Find By Id, 
        Get Photos  de animais

    Combination:
        Create Combination,
        Delete Combination,
        Find By Id,
        confirmation

    , Feed, Ong e User, 

    Nosso Service fica na pasta Patinhas.Infrastructure.



### 10. Implementar UseCases
### 11. Definir Testes (opcional kk)
### 12. Implementar e Configurar Serviços (Configurar JWT)
### 13. Habilitar Swagger