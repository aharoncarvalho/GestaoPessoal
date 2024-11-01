# Gestão Pessoal


Este projeto é uma aplicação Blazor Server para gerenciar informações de registros de pessoas. Ele utiliza PostgreSQL como banco de dados, que pode ser executado em um container Docker.

## Pré-requisitos
Antes de começar, você precisará ter instalado em sua máquina:

- .NET 6 SDK
- Visual Studio 2022 (com suporte para desenvolvimento em .NET)
- Docker (ou conexão a um banco PostgreSQL)



## Configuração do Banco de Dados
### Configuração do PostgreSQL
Se você está usando PostgreSQL localmente, crie um banco de dados para a aplicação e configure sua conexão no arquivo appsettings.json:

```javascript
{
  "GestaoPessoalContextConnection": 
  "Host=localhost;
  Port=5432;
  Database=;
  Username=;
  Password=;"
}
```

### Executar o Script de Inicialização do Banco
Após iniciar o contêiner, aplique o script de banco de dados (localizado na pasta Database) para criar as tabelas necessárias. Você pode fazer isso usando uma ferramenta de cliente PostgreSQL, como pgAdmin ou DBeaver.

### Executando com Docker
Para executar a aplicação e o banco de dados em Docker, utilize o arquivo docker-compose.yaml que se encontra na raiz do projeto. Insira as configurações de nome de banco, usuário e senha e execute o seguinte comando no terminal:

```
docker-compose up
```

Este comando irá subir o container do PostgreSQL, após isso, é possível rodá-lo através de linha de comando ou pela interface gráfica.

## Migrações do Identity
Este projeto utiliza o ASP.NET Core Identity para gerenciar autenticação e autorização de usuários. Para configurar o banco de dados para o Identity, siga os passos abaixo:

- Adicionar a Migração: Execute o seguinte comando no console do Gerenciador de Pacotes do Visual Studio para criar uma nova migração para o Identity:
```bash
Add-Migration InitialIdentityMigration
```
- Atualizar o Banco de Dados: Após criar a migração, execute o seguinte comando para aplicar as alterações ao banco de dados:
```bash
Update-Database
```
## Executando a Aplicação
- Clone o repositório
```
git clone https://github.com/aharoncarvalho/GestaoPessoal.git
```
- Selecione "Abrir um projeto ou solução".
- Navegue até a pasta do repositório clonado e abra o arquivo .sln.
- Clique em "Iniciar Depuração" (ou pressione F5) para iniciar a aplicação. O Visual Studio irá compilar o projeto e abrir o navegador com a aplicação em execução.
## Referência

 - [Blazor](https://learn.microsoft.com/pt-br/aspnet/core/blazor/?view=aspnetcore-6.0)
 - [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/)
 - [PostgreSQL](https://www.postgresql.org/docs/)
 - [Docker](https://docs.docker.com/)
