# Aplicação Console (.NET 8) + EF Core + Oracle — Sem Code-First

<img width="451" height="324" alt="image" src="https://github.com/user-attachments/assets/b4ff5968-2b3b-487a-80fd-edcf779a0cc8" />


## 🇧🇷 Versão em Português

Este projeto é uma **aplicação Console em .NET 8** que utiliza **Entity Framework Core** com **Oracle** para realizar **CRUD** sobre a tabela `TB_CLIENTE`.  
> **Importante:** O projeto **não** usa Code-First nem Migrations. O banco **já existe** e o mapeamento é feito por atributos (`[Table]`, `[Column]`). O **script SQL** para criar a tabela está no repositório.

### 🧱 Arquitetura (sem Migrations / sem Scaffold)
- **Modelo existente no banco**: tabela `TB_CLIENTE`.
- **Mapeamento por atributos** na classe `Cliente` (`[Table("TB_CLIENTE")]`, `[Column(...)]`).
- **DbContext enxuto** (`AppDbContext`), apenas configurando tipos/precisão quando necessário.
- **Console App** com menu CRUD simples (Inserir, Listar, Atualizar, Excluir).

### 🔧 Requisitos Técnicos
- **.NET SDK**: 8.0+
- **Oracle**: 19c+ (ou compatível com ODP.NET Managed)
- **IDE recomendada**: Visual Studio 2022
- **Acesso ao banco**: host, porta (1521), *service name* (ex.: `ORCL`/`XEPDB1`), usuário e senha

### 📦 Pacotes NuGet (versões)
> Use as versões **8.x** para manter compatibilidade com .NET 8 / EF Core 8.
- `Microsoft.EntityFrameworkCore (8.*)`
- `Oracle.EntityFrameworkCore (8.*)`

Pacotes **opcionais** (não exigidos neste projeto, pois não há migrations/scaffold):
- `Microsoft.EntityFrameworkCore.Tools (8.*)`
- `Microsoft.EntityFrameworkCore.Design (8.*)`

**Instalação via CLI**
```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.*
dotnet add package Oracle.EntityFrameworkCore --version 8.*
