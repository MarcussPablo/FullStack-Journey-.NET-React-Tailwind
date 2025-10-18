# Fullstack Journey (.NET + React + Tailwind)

> ⚙️ Este projeto **não é um roadmap de estudos**, mas sim um **bootcamp coautoral criado em parceria com o ChatGPT**, após dois anos de aprendizado intenso em programação.  
> Este bootcamp consolida todo o conhecimento adquirido nesse tempo, definindo a stack principal como **Fullstack C# / .NET + React**, com foco em arquitetura limpa e desenvolvimento profissional.  
> Antes disso, também obtive experiências com **Node.js** e **Python**, mas o refinamento e a dedicação se manifestam plenamente aqui, neste curso técnico e prático voltado ao **backend .NET** e à integração fullstack moderna.

Meu percurso técnico: do *Hello World* até sistemas fullstack prontos para produção, com foco em **boas práticas, arquitetura limpa e entregas reais de portfólio**.

---

## 🧱 Estrutura Prevista

- **backend/** → API .NET 8 + PostgreSQL + Docker  
- **frontend/** → React + Vite + TailwindCSS  
- **docs/** → Anotações, prints e progresso  
- **scripts/** → Seeds, Migrations e Utilitários  

---

## 🚀 Progresso

- [x] **Módulo 0 — Setup**
- [x] **Módulo 1 — Fundamentos .NET/C#**
- [ ] **Módulo 2 — PostgreSQL + EF Core**
- [ ] **Módulo 3 — API Catálogo (CRUD, filtros, paginação)**
- [ ] **Módulo 4 — Auth (JWT, roles, policies)**
- [ ] **Módulo 5 — React + Tailwind (fundamentos)**
- [ ] **Módulo 6 — Storefront (carrinho/checkout)**
- [ ] **Módulo 7 — Pagamentos (mock)**
- [ ] **Módulo 8 — Testes e observabilidade**
- [ ] **Módulo 9 — Capstone E-commerce**
- [ ] **Módulo 10 — Admin Lite (opcional)**
- [ ] **Módulo 11 — Deploy (opcional)**

---

## 📘 Descrição Detalhada dos Módulos

### ✅ Módulo 0 — Setup
**Objetivo:**  
Configurar o ambiente de desenvolvimento fullstack.

**Tópicos técnicos:**  
- Instalação e configuração do .NET 8 SDK  
- Instalação do Node.js, Vite e TailwindCSS  
- Estrutura inicial do repositório (`backend/`, `frontend/`, `docs/`, `scripts/`)  
- Criação do `.gitignore` e `.editorconfig`  
- Criação da solução `.sln` e projeto `ApiFundamentos`  
- Configuração inicial do **Dockerfile** e **docker-compose**

**Entrega:**  
Repositório organizado e pronto para desenvolvimento.

---

### ✅ Módulo 1 — Fundamentos .NET/C#
**Status:** Concluído — 18/10/2025  

**Objetivo:**  
Dominar a base da criação de APIs com .NET 8 e entender profundamente o ciclo requisição–resposta.

**Tópicos técnicos:**  
- Estrutura de projeto em .NET 8  
- `Program.cs` moderno e pipeline HTTP  
- Conceito e uso de **Controllers** e `[ApiController]`  
- **Rotas, Query Strings e parâmetros**  
- Retornos com `IActionResult` e `Ok()`  
- **Injeção de dependências (DI)**  
- `IEnumerable<T>` e **LINQ** básico  
- Serialização com `System.Text.Json`  
- Boas práticas de nomes, organização e comentários  

**Entrega:**  
API funcional com endpoints básicos (`/hello`, `/hello/{name}` e `/hello?name=`)  
– projeto base para evoluir em cima.

---

### 🧩 Conclusões do módulo
**Aprendizados principais:**  
- Entendimento completo do ciclo requisição → controller → resposta  
- Diferença entre `[FromRoute]`, `[FromQuery]` e `[FromBody]`  
- Criação de um `DTO` e envio de dados via JSON  
- Retornos semânticos com `IActionResult` (`Ok`, `BadRequest`, `Created`, `NotFound`)  
- Organização inicial com boas práticas de estrutura  

**Entregas realizadas:**  
- Projeto ASP.NET 8 configurado e funcional com Swagger  
- Controller `HelloController` criado e testado  
- DTO `UserDto` criado e funcional  
- Testes executados com sucesso no Swagger  

---

### 🗄️ Módulo 2 — PostgreSQL + EF Core
**Objetivo:**  
Aprender persistência de dados real e integração com banco de dados.

**Tópicos técnicos:**  
- Criação e configuração do banco PostgreSQL via **Docker Compose**  
- Instalação e uso do **Entity Framework Core**  
- Criação de **Entidades** e **Contexto (DbContext)**  
- Configuração da Connection String  
- Criação de Migrations e atualização do banco  
- `DbSet<T>`, consultas e comandos (`Add`, `Find`, `Update`, `Remove`)  
- Relações 1:N e N:N básicas  

**Entrega:**  
API conectada ao banco PostgreSQL com migrations e tabelas criadas.

---

### 📦 Módulo 3 — API Catálogo (CRUD completo)
**Objetivo:**  
Construir um CRUD completo com validação e rotas RESTful.

**Tópicos técnicos:**  
- Operações **GET**, **POST**, **PUT**, **DELETE**  
- Validação com `[Required]`, `[MaxLength]` e `ModelState`  
- Repositórios e Services com DI  
- Filtros, paginação e ordenação  
- Padrão Repository + Service Layer  
- Boas práticas de status HTTP  

**Entrega:**  
API de catálogo de produtos funcional, com CRUD completo.

---

### 🔐 Módulo 4 — Auth (JWT, roles e policies)
**Objetivo:**  
Implementar autenticação e autorização profissional com JWT.

**Tópicos técnicos:**  
- Autenticação vs Autorização  
- Configuração de tokens JWT  
- Middlewares de autenticação e autorização  
- Claims, Roles e Policies  
- Registro e login de usuários  
- Proteção de rotas privadas  

**Entrega:**  
Sistema de login funcional com autenticação JWT e autorização baseada em roles.

---

### 💻 Módulo 5 — React + Tailwind (Fundamentos)
**Objetivo:**  
Dominar o setup do front-end e compreender o fluxo React moderno.

**Tópicos técnicos:**  
- Estrutura de projeto com Vite  
- JSX e componentes funcionais  
- Estado e propriedades (`useState`, `props`)  
- Estilização com TailwindCSS  
- Organização de pastas (`components`, `pages`, `hooks`)  
- Comunicação com a API via `fetch`  

**Entrega:**  
Front-end configurado e renderizando dados reais da API.

---

### 🛒 Módulo 6 — Storefront (Carrinho e Checkout)
**Objetivo:**  
Construir o front-end funcional de uma loja simples.

**Tópicos técnicos:**  
- Listagem e detalhamento de produtos  
- Context API e gerenciamento de estado global  
- Carrinho de compras com persistência local  
- Fluxo de checkout e resumo do pedido  

**Entrega:**  
Aplicação de e-commerce funcional (front consumindo API real).

---

### 💳 Módulo 7 — Pagamentos (Mock)
**Objetivo:**  
Simular pagamentos e processar pedidos.

**Tópicos técnicos:**  
- Criação de endpoints de pagamento mockados  
- Integração front–back simulando gateway  
- Confirmação e retorno de status de pagamento  

**Entrega:**  
API com simulação de pagamentos e fluxo de pedido integrado.

---

### 🧪 Módulo 8 — Testes e Observabilidade
**Objetivo:**  
Aprender a garantir qualidade e rastreabilidade do código.

**Tópicos técnicos:**  
- Testes unitários com xUnit  
- Testes de integração  
- Mock de dependências e contexto  
- Logs e monitoramento com Serilog  
- Documentação via Swagger aprimorado  

**Entrega:**  
API com testes cobrindo regras principais e logs estruturados.

---

### 🏁 Módulo 9 — Capstone E-commerce
**Objetivo:**  
Unir tudo em um projeto fullstack completo.

**Tópicos técnicos:**  
- Integração total front + back  
- Auth + CRUD + Checkout + Pagamento  
- Deploy local com **Docker Compose**  
- Testes de performance e otimização  
- Boas práticas de versionamento e commits  

**Entrega:**  
E-commerce funcional fullstack completo (pronto pra portfólio).

---

### ⚙️ Módulo 10 — Admin Lite (Opcional)
**Objetivo:**  
Criar um painel administrativo simples.

**Tópicos técnicos:**  
- CRUD de produtos, categorias e usuários  
- Autenticação de admin  
- Interface com Tailwind e React Router  

**Entrega:**  
Painel administrativo conectado à API principal.

---

### 🚀 Módulo 11 — Deploy (Opcional)
**Objetivo:**  
Aprender a publicar o projeto completo.

**Tópicos técnicos:**  
- Deploy do back-end com **Docker**  
- Deploy do front-end com **Vercel** ou **Netlify**  
- Variáveis de ambiente e configurações seguras  
- Orquestração de containers com `docker-compose up`  

**Entrega:**  
Aplicação fullstack online e funcional, rodando em containers.


---

## 🎧 Bonus — English Intermediate for Devs

> Este módulo bônus tem como objetivo aprimorar o inglês técnico e comunicativo para desenvolvedores,  
> focando na **comunicação profissional, documentação, entrevistas e vocabulário do dia a dia de um dev**.  
> Duração sugerida: 30 a 60 minutos por dia.

---

### 🧠 Objetivo Geral
Desenvolver **fluência funcional** em inglês voltado à área de tecnologia —  
ser capaz de se comunicar com equipes internacionais, entender documentações e participar de reuniões técnicas.

---

### 📘 Estrutura de Módulos

#### 🇬🇧 Módulo 0 — Setup
**Objetivo:** Definir a rotina e o propósito do aprendizado.  
**Conteúdo:**
- Avaliação de nível e vocabulário ativo  
- Criação de rotina diária curta (listening, reading e speaking)  
- Configuração de ferramentas: DeepL, Reverso, YouGlish e TTS  
- Definição do vocabulário técnico prioritário (Git, API, Deploy etc.)

**Entrega:**  
Plano pessoal de estudos (“English Routine Sheet”).

---

#### 🗣️ Módulo 1 — Dev Communication Basics
**Objetivo:**  
Dominar frases e expressões usadas em contextos de equipe e desenvolvimento.

**Tópicos técnicos:**  
- Vocabulário de trabalho remoto (meeting, deadline, issue, branch)  
- Expressões técnicas comuns:  
  - *“Let’s push this to main.”*  
  - *“The API is not responding.”*  
  - *“I’ll handle this bug.”*  
- Como se apresentar e descrever o que faz (*“I work as a fullstack developer using .NET and React”*)  
- Estrutura e entonação de frases em contextos técnicos  

**Prática:**  
Simulações curtas de reuniões diárias (*Daily Standup Roleplay*).

---

#### 💬 Módulo 2 — Tech Vocabulary & Documentation
**Objetivo:**  
Compreender e usar o inglês de documentação e código.

**Tópicos técnicos:**  
- Termos essenciais de programação (loop, array, statement, query, handler, deployment, request)  
- Expressões de documentação técnica (*“returns a promise”, “throws an exception”, “handles the request”*)  
- Diferenças entre termos parecidos (*library vs framework*, *bug vs issue*)  
- Estratégias de leitura técnica e anotações eficazes  

**Prática:**  
Leitura e tradução ativa de trechos reais da Microsoft Docs e MDN.

---

#### 🎙️ Módulo 3 — English for Meetings & Teams
**Objetivo:**  
Falar com naturalidade em contextos profissionais.

**Tópicos técnicos:**  
- Reuniões técnicas e check-ins semanais  
- Feedbacks e sugestões: *“I think we should refactor this part.”*  
- Expressões educadas e neutras para discordar:  
  - *“I see your point, but maybe we can try another approach.”*  
- Como explicar bugs e soluções de forma clara  
- Vocabulário de agilidade (sprint, backlog, release)

**Prática:**  
Roleplays de reuniões com simulações de time global.

---

#### 🧑‍💻 Módulo 4 — Interviews & Personal Branding
**Objetivo:**  
Preparar-se para entrevistas em inglês e fortalecer o perfil profissional.

**Tópicos técnicos:**  
- Perguntas e respostas comuns em entrevistas técnicas  
- Como falar sobre projetos e experiências  
- Explicando stacks e responsabilidades  
- *“Tell me about a time you solved a problem”* — respostas estruturadas  
- Criação de pitch pessoal (*Elevator Pitch*)

**Prática:**  
Gravação e revisão de respostas faladas (auto feedback).

---

#### 🏁 Entrega Final
**Resultado esperado:**  
- Vocabulário ativo de 800–1000 palavras técnicas  
- Capacidade de participar de reuniões em inglês  
- Leitura fluente de documentação  
- Comunicação profissional com recrutadores e colegas estrangeiros  

---

📦 **Material complementar:**  
- Flashcards de vocabulário técnico  
- Áudios com sotaque americano e britânico  
- Planilha “Daily English for Devs”  
- Mini-desafios semanais de conversação e tradução

---

🗂️ **Local:**  
`/bonus/english-intermediate-for-devs/`

💡 **Duração sugerida:**  
De 4 a 6 semanas com prática diária leve.

---
