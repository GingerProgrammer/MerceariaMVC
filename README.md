<h1 align="center">🛒 MerceariaMVC</h1>

---

<div align="center">

[![Typing SVG](https://readme-typing-svg.demolab.com?font=Fira+Code&size=26&pause=1000&color=FF69B4&center=true&vCenter=true&width=900&lines=🛒+Sistema+de+Gerenciamento;💻+ASP.NET+Core+MVC;🧪+Desenvolvimento+com+TDD;🗄️+CRUD+com+Entity+Framework+Core)](https://git.io/typing-svg)

</div>

---

<p align="center">
Sistema de gerenciamento de <b>clientes e produtos</b>,<br>
desenvolvido com <b>ASP.NET Core MVC, C#, Entity Framework Core e SQL Server</b> ✨
</p>

---

## 🌸 Tecnologias Utilizadas

<div align="center">

![.NET](https://img.shields.io/badge/.NET-DB2777?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-EC4899?style=for-the-badge&logo=csharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-F472B6?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-F9A8D4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-BF185D?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![xUnit](https://img.shields.io/badge/xUnit-DB2777?style=for-the-badge&logo=xunit&logoColor=white)

</div>

---

# 📖 Sobre o Projeto

O **MerceariaMVC** é um sistema web desenvolvido em **ASP.NET Core MVC** para gerenciamento de **clientes e produtos** de uma mercearia.

A aplicação utiliza o padrão arquitetural **MVC**, permitindo realizar operações de cadastro, consulta, edição e exclusão de registros.

O projeto também foi desenvolvido utilizando a metodologia **TDD (Test-Driven Development)**, com testes automatizados para validar as principais regras de negócio do sistema.

---

# 🚀 Funcionalidades

### 👤 Clientes

* ✅ Cadastro de clientes
* ✅ Listagem de clientes
* ✅ Visualização dos detalhes
* ✅ Edição de clientes
* ✅ Exclusão de clientes
* ✅ Validação de nome, e-mail e idade
* ✅ Verificação de permissão para compra

### 📦 Produtos

* ✅ Cadastro de produtos
* ✅ Listagem de produtos
* ✅ Visualização dos detalhes
* ✅ Edição de produtos
* ✅ Exclusão de produtos
* ✅ Validação de nome, preço e estoque

---

# 🧪 Desenvolvimento com TDD

O projeto foi desenvolvido utilizando **TDD (Test-Driven Development)**, uma abordagem de desenvolvimento orientada por testes.

A ideia principal do TDD é criar os testes para as regras de negócio e, em seguida, implementar ou ajustar o código para que os testes sejam aprovados.

O processo segue o ciclo:

```text
🔴 Red → 🟢 Green → 🔵 Refactor

* 🔴 **Red:** criação de um teste para uma funcionalidade ou regra que ainda não está funcionando.
* 🟢 **Green:** implementação da lógica necessária para fazer o teste passar.
* 🔵 **Refactor:** melhoria e organização do código mantendo os testes funcionando.

No projeto, foram criados testes automatizados para as classes **Cliente** e **Produto**, verificando diferentes cenários de validação.

### Testes de Clientes

* ✅ Nome vazio ou nulo
* ✅ Nome preenchido apenas com espaços
* ✅ E-mail inválido
* ✅ Cliente menor de 18 anos
* ✅ Cliente com 18 anos
* ✅ Cliente válido
* ✅ Permissão de compra para cliente ativo e maior de idade

### Testes de Produtos

* ✅ Preço inválido
* ✅ Estoque inválido
* ✅ Nome vazio ou nulo
* ✅ Produto com dados válidos

Os testes foram desenvolvidos utilizando o **xUnit**.

---

# 🧪 Executando os Testes

Para executar os testes automatizados pelo terminal:

```bash
dotnet test
```

Também é possível executar os testes diretamente pelo **Test Explorer do Visual Studio**.

---

# 🖥️ Telas do Sistema

## 🏠 Tela Inicial

<p align="center">
  <img src="MerceariaMVC/wwwroot/imagens/TelaInicial.png" width="800">
</p>

---

## 👤 Clientes

<p align="center">
  <img src="MerceariaMVC/wwwroot/imagens/TelaClientes.png" width="800">
</p>

---

## 📦 Produtos

<p align="center">
  <img src="MerceariaMVC/wwwroot/imagens/TelaProdutos.png" width="800">
</p>

---

# ▶️ Como Executar

## Clone o projeto

```bash
https://github.com/GingerProgrammer/MerceariaMVC.git
```

---

## Abra a solução

Abra o projeto utilizando o **Visual Studio 2022**.

---

## Configure a conexão

Edite o arquivo:

```text
appsettings.json
```

Configure a sua string de conexão com o **SQL Server**.

---

## Execute as Migrations

No **Package Manager Console** do Visual Studio:

```powershell
Update-Database
```

---

## Execute o projeto

Pressione **F5** ou clique em **Iniciar** no Visual Studio.

---

# 👨‍💻 Créditos


### Desenvolvedora

**Mariana Fernandes Souza Santos**

---

### Professor

**Wallace Oliveira dos Santos**

---
