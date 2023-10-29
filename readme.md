# FIAP BLOG

Projeto criado para o Tech Challenge da fase 1 do curso de pós graduação em **Arquitetura de Sistemas .NET com Azure**.
Turma **2023/2**
## Sobre o projeto
O projeto desenvolvido é uma WebApi em .NET 7 e com o banco de dados SQL Server 2019.
Para a conexão entre a aplicação e o banco de dados, foi escolhido utilizar o ORM Entity Framework Core 7.0

## Como executar o projeto

 1. Na raiz do projeto execute o seguinte comando: `docker compose up -d`.
 2. Após a inicialização dos containers, acessar o swagger pela seguinte URL [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)
 3. Para efetuar o login na aplicação deve ser utilizado o usuário **Admin** e a senha **Admin**

 
## Documentação da API

A documentação da API está localizada no swagger do projeto, onde também é possivel testar todos os endpoints.

# Levantamento de Requisitos e Critérios de Aceitação

## 1. Introdução
Este documento detalha os requisitos funcionais e não funcionais, juntamente com os critérios de aceitação para o desenvolvimento de uma aplicação baseada em uma API. A aplicação será desenvolvida utilizando C# .NET 7, e tanto a aplicação quanto o banco de dados serão contêinerizados e executados utilizando Docker.

## 2. Requisitos Funcionais

### 2.1 Autenticação (Auth)

Método: Login
Descrição: Permite o login na aplicação através do fornecimento de um usuário e senha, retornando um token de autenticação.
- Parâmetros:
  ```
  "username": "Admin"
  "password": "Admin"
  ```
Retorno: Token de autenticação
### 2.2 Gerenciamento de Usuários (User)

Métodos CRUD para Usuário
Criação, Leitura, Atualização e Exclusão de Usuários
- Parâmetros:
  ```
  "name": "Joao da Silva",
  "username": "joao",
  "type": 1
  ```
### 2.3 Gerenciamento de Categorias (Category)

Métodos CRUD para Categorias
Criação, Leitura, Atualização e Exclusão de Categorias
- Parâmetros:
  ```
  "description": "Vendas"
  ```

### 2.4 Gerenciamento de Posts (Post)

Métodos CRUD para Posts
Criação, Leitura, Atualização e Exclusão de Posts
- Parâmetros:
  ```
    "title": "Veja as novas tendencias de vendas",
  "content": "Aqui temos o texto do post, espero que goste do nosso post",
  "categories": [    1,    2  ]
  ```

## 3. Requisitos Não Funcionais

### 3.1 Tecnologias Utilizadas

- C# .NET 7
- banco de dados (SQL Server)
- Docker

## 4. Critérios de Aceitação

### 4.1 Dockerização

A aplicação deve ser devidamente containerizados e executados sem problemas, seguindo as boas práticas de contêineres.

### 4.2 Documentação do Docker

Deve haver documentação detalhada sobre como iniciar e executar a aplicação e o banco de dados via Docker.

### 4.3 Performance em Ambiente Docker

A aplicação deve manter níveis aceitáveis de desempenho quando executada em ambientes Docker.

### 4.4 Conformidade com Requisitos de Negócio

A aplicação Dockerizada deve atender aos requisitos de negócio estabelecidos e funcionar conforme descrito neste documento.

### 5. Considerações Finais
Este documento de requisitos e critérios de aceitação servirá como guia para o desenvolvimento e implantação da aplicação em ambientes Dockerizados. A colaboração com a equipe de desenvolvimento e operações é essencial para garantir o atendimento preciso e eficaz dos requisitos e critérios estabelecidos.
