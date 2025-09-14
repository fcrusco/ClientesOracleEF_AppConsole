# Aplicação Console (.NET 8) + EF Core + Oracle — Sem Code-First

<img width="451" height="324" alt="image" src="https://github.com/user-attachments/assets/ccb81e6f-f1aa-4fb0-90b3-0b97b2020a66" />


## 🇧🇷 Versão em Português

Este projeto é uma **aplicação Console em .NET 8** que utiliza **Entity Framework Core** com **Oracle** para realizar **CRUD** sobre a tabela `TB_CLIENTE`.

> **Importante:** O projeto **não** usa Code-First nem Migrations. O banco **já existe** e o mapeamento é feito por atributos (`[Table]`, `[Column]`). O **script SQL** para criar a tabela está disponível no repositório.

### 🔧 Requisitos Técnicos
- **.NET SDK**: 8.0+
- **Oracle**: 19c+ (ou compatível com ODP.NET Managed)
- **IDE recomendada**: Visual Studio 2022
- **Acesso ao banco**: host, porta (1521), *service name* (ex.: `ORCL`/`XEPDB1`), usuário e senha

### 📦 Pacotes NuGet Utilizados
- `Microsoft.EntityFrameworkCore (8.*)`
- `Oracle.EntityFrameworkCore (8.*)`


### 📑 Estrutura do Projeto
- **Model/Cliente.cs** → Entidade com `[Table]`/`[Column]`
- **DBContext/AppDbContext.cs** → Contexto EF Core (configuração mínima de mapeamento)
- **Program.cs** → Console App com menu CRUD (Inserir, Listar, Atualizar, Excluir)
- **sql/TB_CLIENTE.sql** → Script para criação da tabela

### 📜 Script de Banco de Dados
O repositório contém o script SQL para criação manual da tabela `TB_CLIENTE`.  
Esse script deve ser executado no **schema do usuário configurado na connection string** antes de rodar a aplicação.

### ▶️ Como Executar
1. Garanta que a tabela `TB_CLIENTE` existe (rode o script do repositório).
2. Compile: `dotnet build`
3. Execute: `dotnet run`
4. Utilize o menu no console para Inserir/Listar/Atualizar/Excluir.

---

## 🇺🇸 English Version

This project is a **.NET 8 Console Application** using **Entity Framework Core** with **Oracle** to perform **CRUD** over the `TB_CLIENTE` table.

> **Important:** This project **does not** use Code-First or Migrations. The database **already exists**, and the mapping is done with attributes (`[Table]`, `[Column]`). The **SQL script** to create the table is included in the repository.

### 🔧 Technical Requirements
- **.NET SDK**: 8.0+
- **Oracle**: 19c+ (compatible with ODP.NET Managed)
- **Recommended IDE**: Visual Studio 2022
- **DB access**: host, port (1521), *service name* (e.g., `ORCL`/`XEPDB1`), user and password

### 📦 NuGet Packages Used
- `Microsoft.EntityFrameworkCore (8.*)`
- `Oracle.EntityFrameworkCore (8.*)`

### 📑 Project Structure
- **Model/Cliente.cs** → Entity with `[Table]`/`[Column]`
- **DBContext/AppDbContext.cs** → EF Core context (minimal mapping configuration)
- **Program.cs** → Console CRUD menu (Insert, List, Update, Delete)
- **sql/TB_CLIENTE.sql** → Table creation script

### 📜 Database Script
The repository includes the SQL script to manually create the `TB_CLIENTE` table.  
Run this script in the **schema/user defined in the connection string** before running the application.

### ▶️ How to Run
1. Ensure that `TB_CLIENTE` exists (execute the provided script).
2. Build: `dotnet build`
3. Run: `dotnet run`
4. Use the console menu to Insert/List/Update/Delete.

---

## 🇪🇸 Versión en Español

Este proyecto es una **Aplicación de Consola en .NET 8** que utiliza **Entity Framework Core** con **Oracle** para realizar **CRUD** sobre la tabla `TB_CLIENTE`.

> **Importante:** El proyecto **no** usa Code-First ni Migrations. La base de datos **ya existe** y el mapeo se realiza mediante atributos (`[Table]`, `[Column]`). El **script SQL** para crear la tabla está disponible en el repositorio.

### 🔧 Requisitos Técnicos
- **.NET SDK**: 8.0+
- **Oracle**: 19c+ (compatible con ODP.NET Managed)
- **IDE recomendada**: Visual Studio 2022
- **Acceso a la BD**: host, puerto (1521), *service name* (ej.: `ORCL`/`XEPDB1`), usuario y contraseña

### 📦 Paquetes NuGet Utilizados
- `Microsoft.EntityFrameworkCore (8.*)`
- `Oracle.EntityFrameworkCore (8.*)`

### 📑 Estructura del Proyecto
- **Model/Cliente.cs** → Entidad con `[Table]`/`[Column]`
- **DBContext/AppDbContext.cs** → Contexto EF Core (configuración mínima)
- **Program.cs** → Menú CRUD de consola (Insertar, Listar, Actualizar, Eliminar)
- **sql/TB_CLIENTE.sql** → Script de creación de tabla

### 📜 Script de Base de Datos
El repositorio contiene el script SQL para la creación manual de la tabla `TB_CLIENTE`.  
Debe ejecutarse en el **mismo esquema/usuario configurado en la cadena de conexión** antes de ejecutar la aplicación.

### ▶️ Ejecución
1. Asegúrese de que `TB_CLIENTE` exista (ejecute el script provisto).
2. Compilar: `dotnet build`
3. Ejecutar: `dotnet run`
4. Use el menú de consola para Insertar/Listar/Actualizar/Eliminar.
