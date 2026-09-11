<div align="center">

[![Typing SVG](https://readme-typing-svg.demolab.com?font=Fira+Code&size=28&pause=1000&color=FF69B4&center=true&vCenter=true&width=850&lines=%E2%9C%A6+Ol%C3%A1%2C+seja+bem-vindo+devs+e+divas!+%E2%9C%A6+Eu+sou+a+Mariana+Fernandes)](https://github.com/GingerProgrammer)

<br>

![C#](https://img.shields.io/badge/C%23-FF69B4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET%208-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-FF69B4?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-FF69B4?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-FF69B4?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-FF69B4?style=for-the-badge&logo=javascript&logoColor=white)
![xUnit](https://img.shields.io/badge/xUnit-FF69B4?style=for-the-badge&logo=xunit&logoColor=white)

</div>

# 🛒 MerceariaMVC

## 📌 Sobre o projeto

O **MerceariaMVC** é um sistema desenvolvido em **ASP.NET Core MVC** para o gerenciamento de uma mercearia.

O projeto permite realizar operações de cadastro, consulta, edição e exclusão de **clientes** e **produtos**, utilizando o conceito de **CRUD**.

Além disso, o sistema possui **testes unitários** para validar as regras de negócio das entidades `Cliente` e `Produto`.

---

## ⚙️ Funcionalidades

### 👤 Clientes

- ➕ Cadastro de clientes
- 📋 Listagem de clientes
- 🔎 Visualização dos dados
- ✏️ Edição de clientes
- 🗑️ Exclusão de clientes
- ✅ Validação dos dados do cliente
- 🔐 Verificação de permissão

### 📦 Produtos

- ➕ Cadastro de produtos
- 📋 Listagem de produtos
- 🔎 Visualização dos dados
- ✏️ Edição de produtos
- 🗑️ Exclusão de produtos
- 💰 Validação do preço
- 📊 Validação do estoque
- 📝 Validação do nome

---

## 💻 Tecnologias utilizadas

<div align="center">

![C#](https://img.shields.io/badge/C%23-FF69B4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET%208-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core%20MVC-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-FF69B4?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Razor](https://img.shields.io/badge/Razor-FF69B4?style=for-the-badge&logo=dotnet&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-FF69B4?style=for-the-badge&logo=bootstrap&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-FF69B4?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-FF69B4?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-FF69B4?style=for-the-badge&logo=javascript&logoColor=white)
![xUnit](https://img.shields.io/badge/xUnit-FF69B4?style=for-the-badge&logo=xunit&logoColor=white)

</div>

---

## 🔄 CRUD

O sistema utiliza o conceito de **CRUD**, que representa as quatro operações básicas de gerenciamento de dados:

- 🟢 **Create:** criação de novos registros.
- 🔵 **Read:** consulta e visualização dos registros.
- 🟡 **Update:** alteração de registros existentes.
- 🔴 **Delete:** exclusão de registros.

Essas operações são utilizadas principalmente para o gerenciamento de **Clientes** e **Produtos**.

---

## 🧪 TDD

O projeto também trabalha com o conceito de **TDD (Test-Driven Development)**, ou **Desenvolvimento Orientado a Testes**.

O TDD é uma metodologia de desenvolvimento em que os testes são utilizados antes e durante a implementação das funcionalidades. O objetivo é garantir que o código desenvolvido esteja de acordo com o comportamento esperado.

O processo do TDD normalmente segue três etapas:

### 🔴 Red

Primeiro é criado um teste que representa o comportamento esperado. Inicialmente, o teste deve falhar.

### 🟢 Green

Depois é desenvolvido ou ajustado o código necessário para que o teste passe.

### 🔵 Refactor

Por último, o código pode ser reorganizado e melhorado, mantendo os testes funcionando corretamente.

### 🧩 TDD no projeto

Neste projeto foram criados testes para verificar as regras de validação das classes:

- `Cliente`
- `Produto`

Os testes utilizam **xUnit**.

### 👤 Validações de Cliente

A classe `Cliente` possui validações para verificar:

- Se o nome foi preenchido.
- Se o e-mail possui `@`.
- Se o cliente possui idade igual ou superior a 18 anos.
- Se o cliente possui permissão de acordo com seu status e idade.

### 📦 Validações de Produto

A classe `Produto` possui validações para verificar:

- Se o nome foi preenchido.
- Se o preço é maior que zero.
- Se o estoque é maior que zero.

---

## 🧪 Testes

Os testes estão organizados no projeto:

`MerceariaMVCTests`

- `ClienteTeste.cs`
- `ProdutoTests.cs`

Para executar os testes, utilize:

```bash
dotnet test

🗄️ Banco de dados

O projeto utiliza SQL Server como banco de dados.

A comunicação entre a aplicação e o banco é realizada utilizando o Entity Framework Core.

O contexto utilizado no projeto é:

MerceariaMVCContext

As principais entidades são:

Cliente
Produto
📁 Estrutura do projeto
MerceariaMVC/
│
├── MerceariaMVC/
│   ├── Controllers/
│   │   ├── ClienteController.cs
│   │   ├── HomeController.cs
│   │   └── ProdutoController.cs
│   │
│   ├── Data/
│   │   └── MerceariaMVCContext.cs
│   │
│   ├── Models/
│   │   ├── Cliente.cs
│   │   ├── Produto.cs
│   │   └── ErrorViewModel.cs
│   │
│   ├── Migrations/
│   │
│   ├── Views/
│   │   ├── Cliente/
│   │   ├── Produto/
│   │   ├── Home/
│   │   └── Shared/
│   │
│   ├── wwwroot/
│   │
│   ├── Program.cs
│   ├── appsettings.json
│   └── MerceariaMVC.csproj
│
└── MerceariaMVCTests/
    ├── ClienteTeste.cs
    ├── ProdutoTests.cs
    └── MerceariaMVCTests.csproj
🚀 Como executar
📥 Restaurar os pacotes
dotnet restore
▶️ Executar o projeto
dotnet run
🧪 Executar os testes
dotnet test

Antes de executar o sistema, verifique a string de conexão com o SQL Server no arquivo:

appsettings.json

📚 Objetivo

O projeto tem como objetivo aplicar na prática conceitos de:

Desenvolvimento Web com ASP.NET Core MVC
Programação em C#
Entity Framework Core
Banco de dados SQL Server
Operações CRUD
Validação de dados
Testes unitários
TDD

👩‍💻 Créditos
Desenvolvedor

Mariana Fernandes Souza Santos

👨‍🏫 Professor

Wallace Oliveira dos Santos
