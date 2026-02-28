# AgroSolutions - User Service

Serviço responsável pelo gerenciamento de usuários da plataforma **AgroSolutions**.

Este microsserviço gerencia cadastro, autenticação, validações de e-mail e regras de segurança relacionadas aos usuários do sistema.

---

## Arquitetura

Este serviço segue os princípios de:

- Clean Architecture
- DDD (Domain-Driven Design)
- SOLID
- Separação por camadas:
  - API
  - Application
  - Domain
  - Infrastructure

---

## Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Docker
- GitHub Actions (CI/CD)
- Swagger (OpenAPI)

---

## Responsabilidades do Serviço

- Cadastro de usuário
- Validação de e-mail
- Validação de senha forte
- Prevenção de usuários duplicados
- Autenticação (JWT)
- Middleware de tratamento de erros
- Logs estruturados

---

## Regras de Negócio

- E-mail deve ser válido
- Senha deve conter:
  - Letra maiúscula
  - Letra minúscula
  - Número
  - Caractere especial
- Não permitir e-mail duplicado
- Senha armazenada com hash seguro

---

##  Como Executar Localmente

### 1 - Clonar repositório

- bash
  
git clone https://github.com/seuusuario/AgroSolutions-UserService.git
cd AgroSolutions-UserService

### 2 - Rodar com .NET
dotnet restore
dotnet run --project src/AgroSolutions.UserService.API

### Executando com Docker
-Build
docker build -t agrosolutions-userservice .
-Run
docker run -p 8080:80 agrosolutions-userservice

---

##  CI/CD

Este projeto utiliza GitHub Actions para:
- Build automático
- Criação de imagem Docker
- Publicação no Docker Hub

Pipeline localizado em:
.github/workflows/
