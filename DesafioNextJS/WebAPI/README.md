# WebAPI Core - README

Este projeto é uma WebAPI construída com ASP.NET Core que gerencia informações de Categoria de Clientes. Neste README, você encontrará informações sobre como rodar o projeto, comandos básicos para executar no Visual Studio Code (VS Code), exemplos de como usar os recursos do OData e recomendações de API Client.

## Como rodar o projeto WebAPI Core

Para rodar o projeto WebAPI Core, siga os passos abaixo:

1. Clone o repositório para o seu ambiente local.

2. Certifique-se de ter o .NET SDK instalado no seu sistema. Você pode fazer o download da versão mais recente do .NET SDK em: https://dotnet.microsoft.com/download

3. Abra o terminal ou prompt de comando na pasta raiz do projeto.

4. Restaure as dependências do projeto digitando o seguinte comando:

```bash
dotnet restore
```

5. Crie o banco de dados e execute as migrações com o seguinte comando:

```bash
dotnet ef database update
```

6. Inicie o servidor web executando o seguinte comando:

```bash
dotnet run
```

Agora a aplicação WebAPI Core estará rodando em `https://localhost:7190`.
Você pode utilizar o Swagger `https://localhost:7190/swagger/index.html`


## Comandos básicos para executar no VS Code

No Visual Studio Code, você pode utilizar os seguintes comandos para rodar o projeto:

- `Ctrl + Shift + `: Abre o terminal integrado no VS Code.
- `dotnet restore`: Restaura as dependências do projeto.
- `dotnet ef database update`: Cria o banco de dados e executa as migrações.
- `Ctrl + F5`: Inicia o servidor web.

## Exemplos de como usar os tipos de OData

A API WebAPI Core tem suporte a consultas OData. Aqui estão alguns exemplos de como você pode usar os tipos de OData:

1. **Filtragem**: Para filtrar resultados, utilize o parâmetro `$filter`. Por exemplo, para obter categorias com o nome igual a "GERDAU":

```
https://localhost:7190/api/CategoriaCliente?$filter=Nome eq 'GERDAU'
```

2. **Ordenação**: Para ordenar os resultados, utilize o parâmetro `$orderby`. Por exemplo, para ordenar as categorias pelo nome em ordem crescente:

```
https://localhost:7190/api/CategoriaCliente?$orderby=Nome
```

3. **Paginação**: Para realizar a paginação dos resultados, utilize os parâmetros `$skip` e `$top`. Por exemplo, para pular os primeiros 10 registros e pegar os próximos 5:

```
https://localhost:7190/api/CategoriaCliente?$skip=10&$top=5
```

## Recomendações de API Client

Para testar a API WebAPI Core, você pode utilizar diferentes API Clients. Alguns dos mais populares são:

- **Postman**: Uma ferramenta de colaboração para desenvolvimento de APIs. Saiba mais em: https://www.postman.com/

- **Insomnia**: Outra excelente ferramenta de teste de APIs. Saiba mais em: https://insomnia.rest/

- **Swagger UI**: A própria API WebAPI Core possui o Swagger UI incorporado, permitindo testar e explorar os endpoints diretamente no navegador. Acesse `https://localhost:7190/swagger` após rodar o projeto para utilizá-lo.

**Nota: Recomenda-se desabilitar Validação de Certificados**
