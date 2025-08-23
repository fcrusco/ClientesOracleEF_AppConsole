# Aplicação Console com Entity Framework Core e Oracle

---
<img width="451" height="324" alt="image" src="https://github.com/user-attachments/assets/900b03c1-0820-4afc-bda8-a00cab29f5f4" />

## 🇧🇷 Versão em Português

Este projeto é uma aplicação **Console App em .NET 8** que utiliza o **Entity Framework Core (EF Core)**, com integração ao **banco de dados Oracle**.

### 🔧 Requisitos Técnicos
- **.NET SDK**: 8.0 ou superior  
- **Banco de Dados**: Oracle 19c ou superior (compatível com ODP.NET)  
- **IDE recomendada**: Visual Studio 2022  

### 📦 Pacotes NuGet Utilizados
- `Microsoft.EntityFrameworkCore` (versão 8.*)  
- `Oracle.EntityFrameworkCore` (versão 8.*)  

Esses pacotes garantem o suporte ao EF Core, ferramentas de migração e o provider oficial da Oracle.

### 📑 Estrutura do Projeto
- **Model**: contém a entidade `Cliente`, que representa a tabela `TB_CLIENTE`.  
- **DBContext**: contém a classe `AppDbContext`, responsável pela comunicação com o banco de dados.  
- **Program.cs**: aplicação de console com menu CRUD (Inserir, Listar, Atualizar, Excluir).  

### 📜 Script de Banco de Dados
O repositório inclui o script SQL para criação manual da tabela `TB_CLIENTE`, caso necessário.  

---

## 🇺🇸 English Version

This project is a **.NET 8 Console Application** using **Entity Framework Core (EF Core)** in **Code-First** mode, integrated with an **Oracle database**.

### 🔧 Technical Requirements
- **.NET SDK**: 8.0 or higher  
- **Database**: Oracle 19c or higher (compatible with ODP.NET)  
- **Recommended IDE**: Visual Studio 2022  

### 📦 NuGet Packages Used
- `Microsoft.EntityFrameworkCore` (version 8.*)  
- `Oracle.EntityFrameworkCore` (version 8.*)  

These packages provide EF Core support, migration tools, and the official Oracle provider.

### 📑 Project Structure
- **Model**: contains the `Cliente` entity, representing the `TB_CLIENTE` table.  
- **DBContext**: contains the `AppDbContext` class, responsible for database communication.  
- **Program.cs**: console application with CRUD menu (Insert, List, Update, Delete).  

### 📜 Database Script
The repository includes an SQL script for manual creation of the `TB_CLIENTE` table if needed.  

---

## 🇪🇸 Versión en Español

Este proyecto es una **Aplicación de Consola en .NET 8** que utiliza **Entity Framework Core (EF Core)** en el modelo **Code-First**, con integración a una **base de datos Oracle**.

### 🔧 Requisitos Técnicos
- **.NET SDK**: 8.0 o superior  
- **Base de Datos**: Oracle 19c o superior (compatible con ODP.NET)  
- **IDE recomendada**: Visual Studio 2022  

### 📦 Paquetes NuGet Utilizados
- `Microsoft.EntityFrameworkCore` (versión 8.*)  
- `Oracle.EntityFrameworkCore` (versión 8.*)  

Estos paquetes garantizan el soporte de EF Core, las herramientas de migración y el proveedor oficial de Oracle.

### 📑 Estructura del Proyecto
- **Model**: contiene la entidad `Cliente`, que representa la tabla `TB_CLIENTE`.  
- **DBContext**: contiene la clase `AppDbContext`, responsable de la comunicación con la base de datos.  
- **Program.cs**: aplicación de consola con menú CRUD (Insertar, Listar, Actualizar, Eliminar).  

### 📜 Script de Base de Datos
El repositorio incluye el script SQL para la creación manual de la tabla `TB_CLIENTE`, si fuera necesario.  

