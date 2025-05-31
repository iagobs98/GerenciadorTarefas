Este repositório contém uma API de gerenciamento de tarefas desenvolvida com ASP.NET WebApi utilizando .NET 8, com banco de dados SQL Server Express.

## Funcionalidades

- [x] CRUD completo de Tarefa

## Tecnologias e Pacotes

- [.NET 8 (8.0.16)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Banco de dados SQL Server Express
- Entity Framework Core *( 9.0.5 )*
- FluentValidation *( 12 )*


## ⚙️ Requisitos

- .NET 8 SDK
- SQL Server Express instalado
- Visual Studio 2022 ( utilizei a versão 17.14.2 )


## 🚀 Como rodar o projeto localmente

1. **Clone o repositório**
2. No arquivo **appsettings.Development.json**, configure a conexão com o SQL Server Express:
3. No visual Studio, Vá até o menu: Ferramentas → Gerenciador de Pacotes NuGet → Console do Gerenciador de Pacotes.
4. Selecione o projeto **Infrastructure\GerenciadorTarefas.Data** e rode as migrations através do comando: **update-database**
5. Rode a aplicação através do comando: **dotnet run --project GerenciadorTarefas.API**
6. Verifique e copie a url onde a API está rodando, por exemplo: **http://localhost:5112**. 
7. Siga para clone do projeto web [GerenciadorTarefasApp](https://github.com/iagobs98/GerenciadorTarefasApp)

