
# SalesWebMvc - ASP.NET Core MVC Workshop

This project was developed as part of an **ASP.NET Core MVC workshop**.  
It implements a **full CRUD for SalesRecords**, where:

- Each sale is associated with a **Seller**;
- Each seller belongs to a **Department**.

## 🛠️ Technologies Used

- ASP.NET Core MVC  
- Entity Framework Core (with SQLite or SQL Server)  
- Razor Views  
- Bootstrap (basic layout)  
- C#

## 📁 Project Structure

- `Models/`: Contains the entities `Seller`, `Department`, and `SalesRecord`  
- `Controllers/`: Controllers for each entity  
- `Views/`: Razor Pages grouped by entity  
- `Data/`: Database context (`SalesWebMvcContext`) and `SeedingService` for initial data  
- `Services/`: Business logic and data access layer

---

## 🚀 How to Run the Project Locally

### 1. Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/YOUR_REPOSITORY.git
cd YOUR_REPOSITORY
```

### 2. Open in Visual Studio

- Double-click the `.sln` file or open via Visual Studio:  
  - `File` → `Open` → `Project/Solution...`

### 3. Set up the Database

> The project uses **Entity Framework Core** with Migrations to set up the database.

Run the following commands in the Visual Studio Package Manager Console:

```powershell
Update-Database
```

Or, if using the CLI:

```bash
dotnet ef database update
```

⚠️ If you don’t have EF Core CLI installed:

```bash
dotnet tool install --global dotnet-ef
```

### 4. Run the Project

- Press `F5` or click **Start (IIS Express)** in Visual Studio.

### 5. Initial Data

The project includes a *seeding* service (`SeedingService.cs`) that populates the database with:

- Sample departments  
- Dummy sellers  
- Simulated sales records  

This service runs automatically at startup in development mode.

---

## 📸 Features

- List, create, edit, and delete **Departments**  
- List, create, edit, and delete **Sellers**  
- List, create, edit, and delete **Sales Records**  
- Form validations  
- Paging and filtering (if implemented)

---

## 🤝 Contributing

This project was created for educational purposes.  
Feel free to clone it, explore, modify, and suggest improvements!

---

## 📄 License

This project is free for educational use and is licensed under the MIT License.




# SalesWebMvc - Workshop ASP.NET Core MVC

Este é um projeto desenvolvido como parte de um **workshop de ASP.NET Core MVC**.  
O projeto implementa um **CRUD completo para SalesRecords (Registros de Vendas)**, onde:

- Cada venda está associada a um **vendedor (Seller)**;
- Cada vendedor pertence a um **departamento (Department)**.

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core MVC  
- Entity Framework Core (com SQLite ou SQL Server)  
- Razor Views  
- Bootstrap (para layout básico)  
- C#

## 📁 Estrutura do Projeto

- `Models/`: Contém as entidades `Seller`, `Department`, e `SalesRecord`;  
- `Controllers/`: Controladores para cada entidade;  
- `Views/`: Páginas Razor organizadas por entidade;  
- `Data/`: Contexto do banco (`SalesWebMvcContext`) e `SeedingService` para popular dados iniciais;  
- `Services/`: Camada de serviço para lógica de negócio e acesso aos dados.

---

## 🚀 Como rodar o projeto localmente

### 1. Clone o repositório

```bash
git clone https://github.com/SEU_USUARIO/SEU_REPOSITORIO.git
cd SEU_REPOSITORIO
```

### 2. Abra no Visual Studio

- Dê um duplo clique no arquivo `.sln` ou abra via Visual Studio:  
  - `Arquivo` → `Abrir` → `Projeto/Solução...`

### 3. Configure o banco de dados

> O projeto utiliza o **Entity Framework Core** com Migrations para criar o banco.

Execute os seguintes comandos no terminal do Visual Studio (Package Manager Console):

```powershell
Update-Database
```

Ou, se estiver usando o terminal CLI:

```bash
dotnet ef database update
```

⚠️ Se você não tiver o EF Core CLI instalado:

```bash
dotnet tool install --global dotnet-ef
```

### 4. Execute o projeto

- Pressione `F5` ou clique em **Iniciar (IIS Express)** no Visual Studio.

### 5. Dados iniciais

O projeto inclui um serviço de *seeding* (`SeedingService.cs`) que popula o banco de dados com:

- Departamentos de exemplo  
- Vendedores fictícios  
- Registros de venda simulados  

Esse serviço é executado automaticamente na inicialização do projeto em ambiente de desenvolvimento.

---

## 📸 Funcionalidades

- Listar, criar, editar e excluir **Departamentos**  
- Listar, criar, editar e excluir **Vendedores**  
- Listar, criar, editar e excluir **Registros de Venda**  
- Validações de formulário  
- Paginação e busca (se implementado)

---

## 🤝 Contribuição

Este projeto foi desenvolvido para fins educacionais.  
Sinta-se à vontade para clonar, estudar, modificar e sugerir melhorias!

---

## 📄 Licença

Este projeto é livre para uso educacional e está sob a licença MIT.
