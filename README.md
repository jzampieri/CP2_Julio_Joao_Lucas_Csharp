# CP2 - Sistema de Agendamento de Consultas

---

## Alunos participantes
- Julio Cesar Zampieri RM 98772
- João Gabriel Dias de Mello Nascimento RM 99092
- Lucas Carlos Bandeira Teixeira RM 98640

## 📄 Descrição do Projeto
Sistema de Agendamento de Consultas desenvolvido em **C#** (.NET 8) para uma clínica.

O aplicativo é executado via **Console** e permite:
- Cadastro de **Pacientes** e **Médicos**.
- **Agendamento** de Consultas.
- **Listagem** e **Alteração** de Consultas.
- **Relatório Diário** de Consultas agendadas.

---

## Versão do .NET Utilizada
- **.NET 8.0 (LTS)**

Certifique-se de ter o **SDK do .NET 8** instalado para compilar e rodar o projeto.

Link para download: [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

---

## 📜 Passo a Passo para Executar o Projeto

1. **Clone o repositório:**
```bash
 git clone https://github.com/jzampieri/CP2_Julio_Joao_Lucas_Csharp
```

2. **Abra no Visual Studio 2022+ ou VS Code.**

3. **Restaure as dependências** (caso solicitado).

4. **Compile o projeto:**
```bash
 dotnet build
```

5. **Execute o projeto:**
```bash
 dotnet run
```

6. **Utilize o menu interativo** no Console para navegar pelas funcionalidades.

---

## 📊 Organização dos Arquivos

```plaintext
CP2_Julio_Joao_Lucas_Csharp
|➔ Models/
|   |➔ Paciente.cs      // Classe Paciente
|   |➔ Medico.cs        // Classe Medico
|   |➔ Consulta.cs      // Classe Consulta
|
|➔ Services/
|   |➔ AgendaService.cs // Gerencia Pacientes, Médicos, Consultas
|
|➔ Program.cs          // Menu principal e interação com usuário
|
|➔ CP2_Nome1_Nome2_Csharp.csproj // Arquivo de configuração do projeto
|
|➔ README.md           // Instruções do projeto
```

**Observação:**
- Cada classe está em seu próprio arquivo.
- As responsabilidades são bem separadas por pastas `Models` e `Services`.
- O `Program.cs` é responsável apenas pelo **menu** e **fluxo de opções**.

---

# Projeto CP2 - FIAP 2025
Sistema de Agendamento de Consultas em C# Console App.

