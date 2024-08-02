# API RESTful com C# e Swagger

Este projeto é uma API RESTful desenvolvida em C# utilizando o Swagger para documentação. O principal objetivo deste projeto é servir como estudo durante o evento NLW # Journey da Rocketseat.

## Funcionalidades

- Criação de endpoints RESTful.
- Documentação automática com Swagger.
- Estrutura simples e modular para facilitar a expansão e manutenção.
- Aplicação de conceitos de Clean Code, Clean Architecture e Domain-Driven Design (DDD) para garantir um código mais limpo, organizado e alinhado com as necessidades do domínio.

## Tecnologias Utilizadas

- **C#**
- **Swagger / Swashbuckle**
- **Entity Framework Core** (opcional, dependendo da necessidade de persistência de dados)

## Requisitos

- .NET 6 SDK ou superior
- Visual Studio 2022 ou Visual Studio Code
- SQL Server (opcional, dependendo da necessidade de persistência de dados)

## Configuração do Ambiente

1. **Clone o repositório:**

    ```bash
    git clone https://github.com/seuusuario/nome-do-repositorio.git
    cd nome-do-repositorio
    ```

2. **Instale as dependências:**

    Abra o projeto no Visual Studio ou Visual Studio Code e restaure as dependências do projeto.

    ```bash
    dotnet restore
    ```

3. **Configure o banco de dados (opcional):**

    Caso esteja utilizando o Entity Framework Core para persistência de dados, configure a string de conexão com o seu banco de dados no arquivo `appsettings.json`.

4. **Execute as migrações (opcional):**

    Caso esteja utilizando o Entity Framework Core, aplique as migrações ao banco de dados.

    ```bash
    dotnet ef database update
    ```

5. **Execute a aplicação:**

    ```bash
    dotnet run
    ```

    A API estará disponível em `https://localhost:5001` ou `http://localhost:5000`.

## Uso

A documentação interativa da API estará disponível através do Swagger. Para acessá-la, navegue até `https://localhost:5001/swagger` ou `http://localhost:5000/swagger` em seu navegador.

## Contribuição

Sinta-se à vontade para contribuir com o projeto através de pull requests. Toda ajuda é bem-vinda!

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo LICENSE para mais detalhes.

## Agradecimentos

- [Rocketseat](https://rocketseat.com.br/) pelo evento NLW # Journey e pelo excelente conteúdo educacional.


