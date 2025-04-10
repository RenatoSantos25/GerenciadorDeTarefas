# 🧠 Projeto: Gerenciador de Tarefas (Aplicando Princípios SOLID)

Este projeto de console foi desenvolvido com o objetivo de aplicar os 5 princípios do SOLID em C#, em um sistema simples de gerenciamento de tarefas com armazenamento totalmente em memória.

---

## 🧩 Funcionalidades

- Criar tarefas
- Listar tarefas
- Marcar como concluídas
- Filtrar por prioridade
- Exibir no console

---

## 🗂️ Estrutura do Projeto

| Pasta/Arquivo | Responsabilidade |
|---------------|------------------|
| `Model/Task.cs` | Representa a entidade Tarefa |
| `Services/Entities/TaskManager.cs` | Lógica de manipulação de tarefas (CRUD) |
| `Services/Interfaces/*.cs` | Interfaces de abstração (ISP, DIP) |
| `View/ConsoleTaskPrinter.cs` | Impressão de tarefas no console |
| `Program.cs` | Interação com o usuário (menu e entrada principal) |

---

## ✅ Aplicação dos Princípios SOLID

### 🔹 **S — Single Responsibility Principle**
Cada classe tem uma única responsabilidade:
- `Task` cuida apenas da estrutura da tarefa.
- `TaskManager` gerencia as tarefas.
- `ConsoleTaskPrinter` exibe as tarefas.
- `Viewing` controla a interface textual com o usuário.

---

### 🔹 **O — Open/Closed Principle**
O sistema está aberto para extensão e fechado para modificação:
- Para criar uma nova forma de exibição (ex: HTML, JSON), basta criar uma nova classe que implemente `ITaskPrinter`.

---

### 🔹 **L — Liskov Substitution Principle**
As interfaces `ITaskPrinter`, `IPrintable` e `ICompletable` podem ser implementadas por outras classes sem quebrar o sistema.
- `ConsoleTaskPrinter` pode ser substituída por outra implementação sem impactar o código do `Program`.

---

### 🔹 **I — Interface Segregation Principle**
Interfaces especializadas e coesas:
- `ICompletable` e `IPrintable` foram criadas com métodos específicos, evitando obrigar classes a implementarem métodos que não usam.

---

### 🔹 **D — Dependency Inversion Principle**
O código depende de abstrações e não de classes concretas:
- O `Program.cs` utiliza a interface `ITaskPrinter`, injetando a implementação `ConsoleTaskPrinter` sem conhecer sua lógica interna.

---

## 🖥️ Execução

Execute o projeto com:

```bash
dotnet run
