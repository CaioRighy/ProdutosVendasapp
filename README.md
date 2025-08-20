# 📦 ProdutosVendasApp

Sistema de **gestão de produtos e vendas** desenvolvido em **C# (.NET Windows Forms)**, com arquitetura em camadas e integração com **SQL Server**.  

Este projeto foi criado para aprendizado de **CRUD**, **Entity Framework**, **organização de camadas** e versionamento de código com **GitHub**.

---

## 🚀 Funcionalidades

- 👤 **Cadastro de Funcionários**  
- 🛒 **Cadastro e Gerenciamento de Produtos**  
- 💰 **Controle de Vendas**  
- ⏱ **Cálculo de Hora Extra (funcionários)**  
- 💾 **Persistência em Banco de Dados (SQL Server)**  

---

## 🏗 Estrutura do Projeto  

ProdutosVendasApp/
│
├── ProdutosVendas.Application/ # Regras de negócio e serviços
├── ProdutosVendas.Domain/ # Entidades e contratos
├── ProdutosVendas.Infrastructure/ # Repositórios e acesso ao banco
├── ProdutosVendas.WinForms/ # Interface gráfica (Windows Forms)
│
├── ProdutosVendasApp.sln # Solution do Visual Studio
└── script.sql # Script de criação e CRUD no SQL Server

yaml
Copiar
Editar

---

## 🛠 Tecnologias Utilizadas

- **C# .NET (Windows Forms)**
- **Entity Framework Core**
- **SQL Server**
- **Visual Studio 2022**
- **Git & GitHub**

---

## ⚙️ Como rodar o projeto

1. **Clonar o repositório**
   ```bash
   git clone https://github.com/CaioRighy/ProdutosVendasApp.git
Abrir a solução

Abra o arquivo ProdutosVendasApp.sln no Visual Studio 2022.

Configurar a string de conexão

No arquivo appsettings.json (em ProdutosVendas.WinForms), ajuste o trecho:

json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=ProdutosVendasDb;User Id=sa;Password=SuaSenha;TrustServerCertificate=True;"
}
Executar as migrações

bash
Copiar
Editar
dotnet ef database update
Rodar o projeto

Clique em Iniciar (▶️) no Visual Studio.

📖 Script SQL (CRUD)
Caso prefira executar diretamente no SQL Server, use o arquivo script.sql incluso no repositório.
Ele contém:

Criação do banco e tabela Produtos

Comandos CRUD:

sql
Copiar
Editar
-- Inserir
INSERT INTO Produtos (Name, Price, Stock) VALUES ('Produto Teste', 10.0, 100);

-- Consultar
SELECT * FROM Produtos;

-- Atualizar
UPDATE Produtos SET Price = 12.5 WHERE Id = 1;

-- Deletar
DELETE FROM Produtos WHERE Id = 1;
👨‍💻 Autor
Projeto desenvolvido por Caio Azevedo Righy
📌 Curso: Análise e Desenvolvimento de Sistemas

📜 Licença
Este projeto é apenas para fins de aprendizado e uso acadêmico.
